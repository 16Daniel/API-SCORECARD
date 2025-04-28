using DashboardApi.Funciones;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml.Style;
using OfficeOpenXml;
using System;
using System.Text.Json;
using DashboardApi.ModelsDashboard;
using System.Linq;

namespace DashboardApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BonosController : ControllerBase
    {
        private readonly Funciones.Funciones _fx;
        private readonly Funciones.FuncionesBonos _fxBonos;
        DashboardContext _dashboardContext;

        public BonosController(Funciones.Funciones funciones, FuncionesBonos funcionesBonos,DashboardContext dashboardContext) 
        {
            _fx = funciones;
            _fxBonos = funcionesBonos;
            _dashboardContext = dashboardContext;
        }

        [HttpPost]
        [Route("getBonosData")]
        public async Task<ActionResult> getBonosData([FromForm] string jdsucursales, [FromForm] DateTime fecha)
        {
            try
            {
                
                List<ReporteBono> data = new List<ReporteBono>(); 
                string mes = fecha.ToString("MM/yyyy");

                int[] arrsucursales = System.Text.Json.JsonSerializer.Deserialize<int[]>(jdsucursales);

                // Primer día del mes
                DateTime primerDia = new DateTime(fecha.Year, fecha.Month, 1);
                // Último día del mes
                DateTime ultimoDia = new DateTime(fecha.Year, fecha.Month, DateTime.DaysInMonth(fecha.Year, fecha.Month));

                foreach (int ids in arrsucursales) 
                {
                    var reporte = _dashboardContext.ReportesBonos.Where(x=> x.Ids == ids && x.Mes == fecha.Date.Month && x.Año == fecha.Date.Year).FirstOrDefault();
                    if (reporte == null)
                    {
                        VentasModel alcancedeventas = await _fxBonos.AlcanceDeVentas(ids, mes);
                        costoModel costossucursales = await _fxBonos.getCosto(alcancedeventas);
                        PorcentajeBebidaModel porcentajeBeidas = await _fxBonos.getPBebidas(ids, primerDia, ultimoDia);
                        inicioAYCModel iniciohdb = await _fxBonos.getInicioAYCHDB(ids, primerDia, ultimoDia);
                        PdiferenciasModel diferenciasData = await _fxBonos.getPDiferencias(ids, primerDia, ultimoDia);
                        PmermasModel mermasdata = await _fxBonos.getMermas(ids, primerDia, ultimoDia, diferenciasData);
                        double porcentajeTareas = await _fxBonos.getPorcentajeTareas(ids, primerDia, ultimoDia);

                        data.Add(new ReporteBono()
                        {
                            alcanceDeVentas = alcancedeventas,
                            costosSucursales = costossucursales,
                            pBebidas = porcentajeBeidas,
                            inicioayc = iniciohdb,
                            diferenciasData = diferenciasData,
                            mermasdata = mermasdata,
                            porcentajeTareas = porcentajeTareas,
                        });
                    }
                    else 
                    {
                        ReporteBono obj = System.Text.Json.JsonSerializer.Deserialize<ReporteBono>(reporte.Jdata);
                        data.Add(obj);
                    }
                
                }

                return StatusCode(StatusCodes.Status200OK,data);

            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new { message = ex.ToString() });
            }
        }

        [HttpPost]
        [Route("JobReporteBonos")]
        public async Task<ActionResult> JobReporteBonos([FromForm] DateTime fecha)
        {
            try
            {
                List<Object> data = new List<Object>();
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
                        PorcentajeBebidaModel porcentajeBeidas = await _fxBonos.getPBebidas(ids, primerDia, ultimoDia);
                        inicioAYCModel iniciohdb = await _fxBonos.getInicioAYCHDB(ids, primerDia, ultimoDia);
                        PdiferenciasModel diferenciasData = await _fxBonos.getPDiferencias(ids, primerDia, ultimoDia);
                        PmermasModel mermasdata = await _fxBonos.getMermas(ids, primerDia, ultimoDia, diferenciasData);
                        double porcentajeTareas = await _fxBonos.getPorcentajeTareas(ids, primerDia, ultimoDia);

                        ReporteBono obj = new ReporteBono()
                        {
                            alcanceDeVentas = alcancedeventas,
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

                return StatusCode(StatusCodes.Status200OK);

            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new { message = ex.ToString() });
            }
        }

        [HttpPost]
        [Route("getExcelBonos")]
        public async Task<ActionResult> getExcelBonos([FromForm] string data, [FromForm] string headers)
        {
            try
            {
                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                };

                List<string> listheaders = System.Text.Json.JsonSerializer.Deserialize<List<string>>(headers); 
                List<MatrizBono> datap = System.Text.Json.JsonSerializer.Deserialize<List<MatrizBono>>(data,options);

                // Habilitar el licenciamiento de EPPlus
                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

                // Crear un nuevo paquete de Excel
                using (var package = new ExcelPackage())
                {
                    // Agregar una nueva hoja al libro
                    var worksheet = package.Workbook.Worksheets.Add("Datos");

                    // Definir los encabezados de las columnas

                    for (int i = 1; i <= listheaders.Count; i++) 
                    {
                        worksheet.Cells[1, i].Value = listheaders[i-1];
                        worksheet.Cells[1, i].Style.Font.Bold = true;
                        worksheet.Cells[1, i].Style.Fill.PatternType = ExcelFillStyle.Solid;
                        worksheet.Cells[1, i].Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.Black);
                        worksheet.Cells[1, i].Style.Font.Color.SetColor(System.Drawing.Color.White);
                    }

                    int row = 2;
                    foreach (var item in datap) 
                    {
                        worksheet.Cells[row, 1].Value = item.Sucursal;
                        worksheet.Cells[row, 2].Value = item.MetaVenta;
                        worksheet.Cells[row, 3].Value = item.VentaReal;
                        
                        worksheet.Cells[row, 4].Value = item.Alcance;
                        worksheet.Cells[row, 4].Style.Font.Bold = true;
                        worksheet.Cells[row, 4].Style.Fill.PatternType = ExcelFillStyle.Solid;
                        worksheet.Cells[row, 4].Style.Fill.BackgroundColor.SetColor(_fxBonos.getBgColorAlcance(item.Alcance));
                        worksheet.Cells[row, 4].Style.Font.Color.SetColor(_fxBonos.esAmarillo(_fxBonos.getBgColorAlcance(item.Alcance)) ? System.Drawing.Color.Black: System.Drawing.Color.White);

                        worksheet.Cells[row, 5].Value = item.Compras;
                        worksheet.Cells[row, 6].Value = item.Costo;
                        worksheet.Cells[row, 7].Value = item.VentaAlimentosSalon;
                        worksheet.Cells[row, 8].Value = item.VentaBebidasSalon;

                        worksheet.Cells[row, 9].Value = item.PorcentajeBebidas;
                        worksheet.Cells[row, 9].Style.Font.Bold = true;
                        worksheet.Cells[row, 9].Style.Fill.PatternType = ExcelFillStyle.Solid;
                        worksheet.Cells[row, 9].Style.Fill.BackgroundColor.SetColor(item.PorcentajeBebidas>=2? System.Drawing.Color.Green : System.Drawing.Color.Red);
                        worksheet.Cells[row, 9].Style.Font.Color.SetColor(System.Drawing.Color.White);

                        worksheet.Cells[row, 10].Value = item.Totalayc;
                        worksheet.Cells[row, 11].Value = item.Inicioaychdb;

                        worksheet.Cells[row, 12].Value = item.Porcentajehdb;
                        worksheet.Cells[row, 12].Style.Font.Bold = true;
                        worksheet.Cells[row, 12].Style.Fill.PatternType = ExcelFillStyle.Solid;
                        worksheet.Cells[row, 12].Style.Fill.BackgroundColor.SetColor(item.Porcentajehdb > 25 ? System.Drawing.Color.Green : System.Drawing.Color.Red);
                        worksheet.Cells[row, 12].Style.Font.Color.SetColor(System.Drawing.Color.White);

                        worksheet.Cells[row, 13].Value = item.DifAla;
                        worksheet.Cells[row, 14].Value = item.ComprasAla;

                        worksheet.Cells[row, 15].Value = item.PdifAla;
                        worksheet.Cells[row, 15].Style.Font.Bold = true;
                        worksheet.Cells[row, 15].Style.Fill.PatternType = ExcelFillStyle.Solid;
                        worksheet.Cells[row, 15].Style.Fill.BackgroundColor.SetColor(_fxBonos.getBgColorDM(item.PdifAla));
                        worksheet.Cells[row, 15].Style.Font.Color.SetColor(System.Drawing.Color.White);

                        worksheet.Cells[row, 16].Value = item.DifBoneless;
                        worksheet.Cells[row, 17].Value = item.ComprasBoneless;

                        worksheet.Cells[row, 18].Value = item.PdifBoneless;
                        worksheet.Cells[row, 18].Style.Font.Bold = true;
                        worksheet.Cells[row, 18].Style.Fill.PatternType = ExcelFillStyle.Solid;
                        worksheet.Cells[row, 18].Style.Fill.BackgroundColor.SetColor(_fxBonos.getBgColorDM(item.PdifBoneless));
                        worksheet.Cells[row, 18].Style.Font.Color.SetColor(System.Drawing.Color.White);

                        worksheet.Cells[row, 19].Value = item.DifPapa;
                        worksheet.Cells[row, 20].Value = item.ComprasPapa;

                        worksheet.Cells[row, 21].Value = item.PdifPapa;
                        worksheet.Cells[row, 21].Style.Font.Bold = true;
                        worksheet.Cells[row, 21].Style.Fill.PatternType = ExcelFillStyle.Solid;
                        worksheet.Cells[row, 21].Style.Fill.BackgroundColor.SetColor(_fxBonos.getBgColorDM(item.PdifPapa));
                        worksheet.Cells[row, 21].Style.Font.Color.SetColor(System.Drawing.Color.White);

                        worksheet.Cells[row, 22].Value = item.MermasAla;

                        worksheet.Cells[row, 23].Value = item.PmermasAla;
                        worksheet.Cells[row, 23].Style.Font.Bold = true;
                        worksheet.Cells[row, 23].Style.Fill.PatternType = ExcelFillStyle.Solid;
                        worksheet.Cells[row, 23].Style.Fill.BackgroundColor.SetColor(_fxBonos.getBgColorDM(item.PmermasAla));
                        worksheet.Cells[row, 23].Style.Font.Color.SetColor(System.Drawing.Color.White);

                        worksheet.Cells[row, 24].Value = item.MermasBoneless;

                        worksheet.Cells[row, 25].Value = item.PmermasBoneless;
                        worksheet.Cells[row, 25].Style.Font.Bold = true;
                        worksheet.Cells[row, 25].Style.Fill.PatternType = ExcelFillStyle.Solid;
                        worksheet.Cells[row, 25].Style.Fill.BackgroundColor.SetColor(_fxBonos.getBgColorDM(item.PmermasBoneless));
                        worksheet.Cells[row, 25].Style.Font.Color.SetColor(System.Drawing.Color.White);

                        worksheet.Cells[row, 26].Value = item.MermasPapa;

                        worksheet.Cells[row, 27].Value = item.PmermasPapa;
                        worksheet.Cells[row, 27].Style.Font.Bold = true;
                        worksheet.Cells[row, 27].Style.Fill.PatternType = ExcelFillStyle.Solid;
                        worksheet.Cells[row, 27].Style.Fill.BackgroundColor.SetColor(_fxBonos.getBgColorDM(item.PmermasPapa));
                        worksheet.Cells[row, 27].Style.Font.Color.SetColor(System.Drawing.Color.White);

                        worksheet.Cells[row, 28].Value = item.PorcentajeTareas;
                        worksheet.Cells[row, 28].Style.Font.Bold = true;
                        worksheet.Cells[row, 28].Style.Fill.PatternType = ExcelFillStyle.Solid;
                        worksheet.Cells[row, 28].Style.Fill.BackgroundColor.SetColor(_fxBonos.getBgColorApps(item.PorcentajeTareas));
                        worksheet.Cells[row, 28].Style.Font.Color.SetColor(_fxBonos.esAmarillo(_fxBonos.getBgColorApps(item.PorcentajeTareas)) ? System.Drawing.Color.Black : System.Drawing.Color.White);

                        row++;
                    }

                    // Ajustar el ancho de las columnas
                    worksheet.Cells.AutoFitColumns();

                    // Configurar la respuesta HTTP para devolver el archivo de Excel
                    var stream = new MemoryStream();
                    package.SaveAs(stream);
                    stream.Position = 0;

                    var byteArray = stream.ToArray();
                    var base64String = Convert.ToBase64String(byteArray);

                    return StatusCode(StatusCodes.Status200OK, new { base64File = base64String });
                }
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new { message = ex.ToString() });
            }
        }
    }

    public class ReporteBono 
    {
        public VentasModel alcanceDeVentas { get; set; }
        public costoModel costosSucursales { get; set; }
        public PorcentajeBebidaModel pBebidas { get; set; }
        public inicioAYCModel inicioayc {  get; set; }
        public PdiferenciasModel diferenciasData { get; set; }
        public PmermasModel mermasdata {  get; set; }
        public double porcentajeTareas {  get; set; } 
    }
    public class MatrizBono
    {
        public int Ids { get; set; }
        public string Sucursal { get; set; }
        public double MetaVenta { get; set; }
        public double VentaReal { get; set; }
        public double Alcance { get; set; }
        public double Compras { get; set; }
        public double Costo { get; set; }
        public double VentaAlimentosSalon { get; set; }
        public double VentaBebidasSalon { get; set; }
        public double PorcentajeBebidas { get; set; }
        public double Totalayc { get; set; }
        public double Inicioaychdb { get; set; }
        public double Porcentajehdb { get; set; }
        public double DifAla { get; set; }
        public double ComprasAla { get; set; }
        public double PdifAla { get; set; }
        public double DifBoneless { get; set; }
        public double ComprasBoneless { get; set; }
        public double PdifBoneless { get; set; }
        public double DifPapa { get; set; }
        public double ComprasPapa { get; set; }
        public double PdifPapa { get; set; }
        public double MermasAla { get; set; }
        public double PmermasAla { get; set; }
        public double MermasBoneless { get; set; }
        public double PmermasBoneless { get; set; }
        public double MermasPapa { get; set; }
        public double PmermasPapa { get; set; }
        public double PorcentajeTareas { get; set; }
    }
}
