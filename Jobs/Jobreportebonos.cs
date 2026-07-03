using DashboardApi.Controllers;
using DashboardApi.Funciones;
using DashboardApi.ModelsDashboard;
using Quartz;

namespace DashboardApi.Jobs
{
    public class Jobreportebonos : IJob
    {
        DashboardContext _dashboardContext;
        private readonly Funciones.FuncionesBonos _fxBonos;
        public Jobreportebonos(DashboardContext dbc, Funciones.FuncionesBonos fxBonos) 
        {
            _dashboardContext = dbc; 
            _fxBonos = fxBonos;
        }
        public async Task Execute(IJobExecutionContext context)
        {
            try
            {
                List<Object> data = new List<Object>();
                DateTime fecha = DateTime.Now.AddMonths(-1);
                string mes = fecha.ToString("MM/yyyy");

                List<int> arrsucursales = await _fxBonos.getSucursales();
                //List<int> arrsucursales = new List<int>();
                //arrsucursales.Add(1);

                // Primer día del mes
                DateTime primerDia = new DateTime(fecha.Year, fecha.Month, 1);
                // Último día del mes
                DateTime ultimoDia = new DateTime(fecha.Year, fecha.Month, DateTime.DaysInMonth(fecha.Year, fecha.Month));

                foreach (int ids in arrsucursales)
                {
                    var reporte = _dashboardContext.ReportesBonos.Where(x => x.Ids == ids && x.Mes == fecha.Date.Month && x.Año == fecha.Date.Year).FirstOrDefault();
                    if (reporte == null)
                    {
                        VentasModel alcancedeventas = await _fxBonos.AlcanceDeVentas(ids, mes);
                        costoModel costossucursales = await _fxBonos.getCosto(alcancedeventas);
                        VentasModel alcancedeventasSalon = await _fxBonos.AlcanceDeVentasSalon(ids, mes);
                        PorcentajeBebidaModel porcentajeBeidas = await _fxBonos.getPBebidas(ids, primerDia, ultimoDia);
                        inicioAYCModel iniciohdb = await _fxBonos.getInicioAYCHDB(ids, primerDia, ultimoDia);
                        PdiferenciasModel diferenciasData = await _fxBonos.getPDiferencias(ids, primerDia, ultimoDia);
                        PmermasModel mermasdata = await _fxBonos.getMermas(ids, primerDia, ultimoDia, diferenciasData);
                        double porcentajeTareas = await _fxBonos.getPorcentajeTareas(ids, primerDia, ultimoDia);

                        ReporteBono obj = new ReporteBono()
                        {
                            alcanceDeVentas = alcancedeventas,
                            alcanceDeVentasSalon = alcancedeventasSalon,
                            costosSucursales = costossucursales,
                            pBebidas = porcentajeBeidas,
                            inicioayc = iniciohdb,
                            diferenciasData = diferenciasData,
                            mermasdata = mermasdata,
                            porcentajeTareas = porcentajeTareas,
                        };

                        if (alcancedeventas.ventaTotal == 0)
                        {
                            Console.WriteLine("");
                        }

                        _dashboardContext.ReportesBonos.Add(new ReportesBono()
                        {
                            Mes = fecha.Date.Month,
                            Año = fecha.Date.Year,
                            Jdata = System.Text.Json.JsonSerializer.Serialize(obj),
                            Ids = ids
                        });

                        await _dashboardContext.SaveChangesAsync();
                    }

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
