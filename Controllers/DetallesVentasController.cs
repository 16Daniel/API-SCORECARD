using DashboardApi.Funciones;
using DashboardApi.Mail;
using DashboardApi.ModelsBD1;
using DashboardApi.ModelsBD2;
using DashboardApi.ModelsDashboard;
using DashboardApi.ModelsDBRebel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System.Data;

namespace DashboardApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DetallesVentasController : ControllerBase
    {
        BD1Context _db1Context;
        BD2Context _db2Context;
        DBRebelContext _dbRebelContext;
        private readonly IConfiguration _configuration;
        public string connectionString = string.Empty;
        public string connectionStringDBREBEL = string.Empty;
        DashboardContext _dashboardContext;
        private readonly MailC _funciones;
        private readonly Funciones.Funciones _fx;
        private readonly Funciones.FuncionesBonos _fxBonos;

        public DetallesVentasController(BD1Context d1Context, BD2Context bD2Context, DBRebelContext dBRebelContext, IConfiguration configuration,
        DashboardContext dashboardcontext, MailC fn, Funciones.Funciones fx, FuncionesBonos fxBonos)
        {
            _db1Context = d1Context;
            _db2Context = bD2Context;
            _dbRebelContext = dBRebelContext;
            _configuration = configuration;
            connectionString = _configuration.GetConnectionString("DefaultConnection");
            connectionStringDBREBEL = _configuration.GetConnectionString("DBREBELWINGS");
            _dashboardContext = dashboardcontext;
            _funciones = fn;
            _fx = fx;
            _fxBonos = fxBonos;
        }

        [HttpPost]
        [Route("ConsultaDashboard")]
        public async Task<ActionResult> consultadash([FromForm] string jdsucursales, [FromForm] string fecha)
        {
            try
            {
                List<SucursalModel> arrsucursales = System.Text.Json.JsonSerializer.Deserialize<List<SucursalModel>>(jdsucursales);
                string[] datos = fecha.Split('-');
                int year = int.Parse(datos[0]);
                int month = int.Parse(datos[1]);
                int day = DateTime.Now.Date.Day;
                if (day > 1)
                {
                    day--;
                }
                int daysInMonth = DateTime.DaysInMonth(year, month);
                List<VentasModel> ventassucursales = new List<VentasModel>();
                foreach (var itemsuc in arrsucursales)
                {
                    VentasModel ventaSuc = new VentasModel();
                    ventaSuc.ids = itemsuc.cod;
                    ventaSuc.nombreSucursal = itemsuc.name;
                    ventaSuc.meta = -1;
                    Boolean sinmeta = false;
                    var cajafront = _db2Context.RemCajasfronts.Where(x => x.Idfront == itemsuc.cod).FirstOrDefault();
                    if (cajafront != null)
                    {
                        var meta = _db2Context.SerieAns.Where(x => x.SerieAn1 == cajafront.Codalmventas && x.Año == year && x.Mes == month).FirstOrDefault();
                        if (meta != null) { ventaSuc.meta = (double)meta.PresupuestoVta; } else { sinmeta = true; }
                    }

                    double sumaTotalNeto = (double)_db2Context.Albventacabs.Where(x => x.Fo == itemsuc.cod && x.Fecha.Value.Month == month && x.Fecha.Value.Year == year && x.Fecha.Value.Date < DateTime.Now.Date).Sum(x => x.Totalneto);
                    ventaSuc.ventaTotal = sumaTotalNeto;
                    ventaSuc.cumplimiento = (sumaTotalNeto / ventaSuc.meta) * 100;
                    if (sinmeta)
                    {
                        ventaSuc.cumplimiento = 0;
                    }
                    else
                    {
                        ventaSuc.cumplimiento = (sumaTotalNeto / ventaSuc.meta) * 100;
                    }
                    ventaSuc.month = month;
                    ventaSuc.year = year;
                    double cumplimientoesp = 0.0;

                    if (DateTime.Now.Date.Year == year && DateTime.Now.Date.Month == month)
                    {
                        cumplimientoesp = (double)100 / (double)daysInMonth;
                        cumplimientoesp = cumplimientoesp * day;

                        if (ventaSuc.meta == -1) { ventaSuc.proyeccion = 0; }
                        else { ventaSuc.proyeccion = (ventaSuc.meta / (double)daysInMonth) * day; }


                    }
                    else
                    {
                        if (ventaSuc.meta == -1) { ventaSuc.proyeccion = 0; }
                        else { ventaSuc.proyeccion = ventaSuc.meta; }
                    }

                    if ((DateTime.Now.Date.Year < year && DateTime.Now.Date.Month < month) || (DateTime.Now.Date.Year == year && DateTime.Now.Date.Month > month))
                    {
                        cumplimientoesp = 100;
                    }


                    ventaSuc.cumplimientoesperado = cumplimientoesp;
                    ventassucursales.Add(ventaSuc);
                }

                return StatusCode(StatusCodes.Status200OK, ventassucursales);

            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new { message = ex.ToString() });
            }
        }

        [HttpGet]
        [Route("DetallesVentas/{ids}/{fecha}")]
        public async Task<ActionResult> detallesventas(int ids, string fecha)
        {
            try
            {
                string[] datos = fecha.Split('-');
                int year = int.Parse(datos[0]);
                int month = int.Parse(datos[1]);

                DetallesVentasModel data = new DetallesVentasModel();

                double salon = 0, pickup = 0, uber = 0, rappi = 0, didi = 0;

                salon = (double)_db2Context.Albventacabs.Where(x => x.Fo == ids && x.Fecha.Value.Month == month && x.Fecha.Value.Year == year && x.Numserie.Contains("T") && x.Fecha.Value.Date < DateTime.Now.Date).Sum(x => x.Totalneto);
                pickup = (double)_db2Context.Albventacabs.Where(x => x.Fo == ids && x.Fecha.Value.Month == month && x.Fecha.Value.Year == year && x.Codcliente == 84 && x.Fecha.Value.Date < DateTime.Now.Date).Sum(x => x.Totalneto);


                double uberco = (double)_db2Context.Albventacabs.Where(x => x.Fo == ids && x.Fecha.Value.Month == month && x.Fecha.Value.Year == year && x.Codcliente == 179 && x.Fecha.Value.Date < DateTime.Now.Date).Sum(x => x.Totalneto);
                double uberfc = (double)_db2Context.Albventacabs.Where(x => x.Fo == ids && x.Fecha.Value.Month == month && x.Fecha.Value.Year == year && x.Codcliente == 177 && x.Fecha.Value.Date < DateTime.Now.Date).Sum(x => x.Totalneto);
                double uberrw = (double)_db2Context.Albventacabs.Where(x => x.Fo == ids && x.Fecha.Value.Month == month && x.Fecha.Value.Year == year && x.Codcliente == 67 && x.Fecha.Value.Date < DateTime.Now.Date).Sum(x => x.Totalneto);
                uber = uberco + uberfc + uberrw;


                double rappico = (double)_db2Context.Albventacabs.Where(x => x.Fo == ids && x.Fecha.Value.Month == month && x.Fecha.Value.Year == year && x.Codcliente == 187 && x.Fecha.Value.Date < DateTime.Now.Date).Sum(x => x.Totalneto);
                double rappifc = (double)_db2Context.Albventacabs.Where(x => x.Fo == ids && x.Fecha.Value.Month == month && x.Fecha.Value.Year == year && x.Codcliente == 186 && x.Fecha.Value.Date < DateTime.Now.Date).Sum(x => x.Totalneto);
                double rappijwi = (double)_db2Context.Albventacabs.Where(x => x.Fo == ids && x.Fecha.Value.Month == month && x.Fecha.Value.Year == year && x.Codcliente == 178 && x.Fecha.Value.Date < DateTime.Now.Date).Sum(x => x.Totalneto);
                double rappirw = (double)_db2Context.Albventacabs.Where(x => x.Fo == ids && x.Fecha.Value.Month == month && x.Fecha.Value.Year == year && x.Codcliente == 185 && x.Fecha.Value.Date < DateTime.Now.Date).Sum(x => x.Totalneto);
                double rappiwd = (double)_db2Context.Albventacabs.Where(x => x.Fo == ids && x.Fecha.Value.Month == month && x.Fecha.Value.Year == year && x.Codcliente == 188 && x.Fecha.Value.Date < DateTime.Now.Date).Sum(x => x.Totalneto);
                rappi = rappico + rappifc + rappijwi + rappirw + rappiwd;



                double didico = (double)_db2Context.Albventacabs.Where(x => x.Fo == ids && x.Fecha.Value.Month == month && x.Fecha.Value.Year == year && x.Codcliente == 182 && x.Fecha.Value.Date < DateTime.Now.Date).Sum(x => x.Totalneto);
                double didifc = (double)_db2Context.Albventacabs.Where(x => x.Fo == ids && x.Fecha.Value.Month == month && x.Fecha.Value.Year == year && x.Codcliente == 183 && x.Fecha.Value.Date < DateTime.Now.Date).Sum(x => x.Totalneto);
                double didijwi = (double)_db2Context.Albventacabs.Where(x => x.Fo == ids && x.Fecha.Value.Month == month && x.Fecha.Value.Year == year && x.Codcliente == 184 && x.Fecha.Value.Date < DateTime.Now.Date).Sum(x => x.Totalneto);
                double didirw = (double)_db2Context.Albventacabs.Where(x => x.Fo == ids && x.Fecha.Value.Month == month && x.Fecha.Value.Year == year && x.Codcliente == 181 && x.Fecha.Value.Date < DateTime.Now.Date).Sum(x => x.Totalneto);
                double didiwd = (double)_db2Context.Albventacabs.Where(x => x.Fo == ids && x.Fecha.Value.Month == month && x.Fecha.Value.Year == year && x.Codcliente == 180 && x.Fecha.Value.Date < DateTime.Now.Date).Sum(x => x.Totalneto);
                didi = didico + didifc + didijwi + didirw + didiwd;

                double total = salon + uber + rappi + didi + pickup;

                data.ids = ids;
                data.ventasalon = salon;
                data.ventapickup = pickup;
                data.ventauber = uber;
                data.ventarappi = rappi;
                data.ventadidi = didi;
                data.ventaTotal = total;

                data.uberco = uberco;
                data.uberfc = uberfc;
                data.uberrw = uberrw;

                data.rappico = rappico;
                data.rappifc = rappifc;
                data.rappijwi = rappijwi;
                data.rappirw = rappirw;
                data.rappiwd = rappiwd;

                data.didico = didico;
                data.didifc = didifc;
                data.didijwi = didijwi;
                data.didirw = didirw;
                data.didiwd = didiwd;

                return StatusCode(StatusCodes.Status200OK, data);

            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new { message = ex.ToString() });
            }
        }

        [HttpGet]
        [Route("DetallesVentas2/{ids}/{fecha}")]
        public async Task<ActionResult> detallesventasP2(int ids, string fecha)
        {
            try
            {
                string[] datos = fecha.Split('-');
                int year = int.Parse(datos[0]);
                int month = int.Parse(datos[1]);

                DetallesVentasP2Model data = new DetallesVentasP2Model();
                double descuentos = 0, mermas = 0, cancelaciones = 0, invitaciones = 0, consumointerno = 0;

                var cajafront = from rf in _db2Context.RemFronts
                                join rcf in _db2Context.RemCajasfronts on rf.Idfront equals rcf.Idfront
                                where rf.Idfront == ids
                                select new
                                {
                                    rf.Titulo,
                                    rcf.Codalmventas
                                };
                string codalmacen = cajafront.FirstOrDefault().Codalmventas;
                var resultdescuentos =
                        from ac in _db2Context.Albventacabs
                        join al in _db2Context.Albventalins on new { ac.Numserie, ac.Numalbaran, ac.N } equals new { al.Numserie, al.Numalbaran, al.N }
                        where al.Tipo != "I" && al.Tipo != "CI"
                              && ac.Fecha.Value.Year == year && ac.Fecha.Value.Month == month && ac.Fo == ids && ac.Fecha.Value.Date < DateTime.Now.Date
                        group new { ac, al } by ac.Numserie.Substring(0, 2) into g
                        select new
                        {
                            IMPORTE = g.Sum(x =>
                                ((x.al.Unidadestotal * (x.al.Precioiva * (1 - (x.al.Dto / 100)))) * (x.ac.Dtocomercial / 100)) +
                                ((x.al.Unidadestotal * (x.al.Precioiva * (1 - (x.al.Dto / 100)))) * (x.ac.Dtopp / 100)) +
                                (x.al.Unidadestotal * (x.al.Precioiva * (x.al.Dto / 100)))
                            )
                        };


                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("GET_MERMAS_SUCURSAL_MES", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@MONTH", month);
                        command.Parameters.AddWithValue("@YEAR", year);
                        command.Parameters.AddWithValue("@IDS", codalmacen);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                mermas = double.Parse(reader["IMPORTE"].ToString());
                            }
                        }
                    }
                }


                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("GET_CONSUMOINTERNO_SUCURSAL_MES", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@MONTH", month);
                        command.Parameters.AddWithValue("@YEAR", year);
                        command.Parameters.AddWithValue("@IDS", ids);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                consumointerno = double.Parse(reader["IMPORTE"].ToString());
                            }
                        }
                    }
                }

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("GET_CANCELACIONES_SUCURSAL_MES", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@MONTH", month);
                        command.Parameters.AddWithValue("@YEAR", year);
                        command.Parameters.AddWithValue("@IDS", ids);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                cancelaciones = double.Parse(reader["IMPORTE"].ToString());
                            }
                        }
                    }
                }

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("GET_INVITACIONES_SUCURSAL_MES", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@MONTH", month);
                        command.Parameters.AddWithValue("@YEAR", year);
                        command.Parameters.AddWithValue("@IDS", ids);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                invitaciones = double.Parse(reader["IMPORTE"].ToString());
                            }
                        }
                    }
                }

                descuentos = (double)resultdescuentos.FirstOrDefault().IMPORTE;

                data.descuentos = descuentos;
                data.mermas = mermas;
                data.consumoInterno = consumointerno;
                data.ids = ids;
                data.invitaciones = invitaciones;
                data.cancelaciones = cancelaciones;
                return StatusCode(StatusCodes.Status200OK, data);

            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new { message = ex.ToString() });
            }
        }

    }
}
