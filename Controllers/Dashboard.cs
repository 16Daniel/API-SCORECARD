using DashboardApi.ModelsBD1;
using DashboardApi.ModelsBD2;
using DashboardApi.Funciones; 
using DashboardApi.ModelsDashboard;
using DashboardApi.ModelsDBRebel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using OfficeOpenXml.Style;
using OfficeOpenXml;
using System.Data;
using System.Globalization;
using DashboardApi.Mail;

namespace DashboardApi.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class Dashboard : ControllerBase
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

        public Dashboard(BD1Context d1Context, BD2Context bD2Context, DBRebelContext dBRebelContext, IConfiguration configuration,
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


    [HttpPost]
    [Route("ConsultaDashboardMeses")]
    public async Task<ActionResult> consultadashMeses([FromForm] string jdsucursales, [FromForm] string fechas)
    {
      try
      {
        string[] meses = System.Text.Json.JsonSerializer.Deserialize<string[]>(fechas);

        List<SucursalModel> arrsucursales = System.Text.Json.JsonSerializer.Deserialize<List<SucursalModel>>(jdsucursales);

        List<VentasModel> ventassucursales = new List<VentasModel>();
        foreach (var itemsuc in arrsucursales)
        {
          foreach (string mes in meses)
          {
            string[] datos = mes.Split('-');
            int year = int.Parse(datos[0]);
            int month = int.Parse(datos[1]);

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

            double sumaTotalNeto = (double)_db2Context.Albventacabs.Where(x => x.Fo == itemsuc.cod && x.Fecha.Value.Month == month && x.Fecha.Value.Year == year).Sum(x => x.Totalneto);
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
            ventassucursales.Add(ventaSuc);
          }
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

    [HttpPost]
    [Route("ConsultaDashboardc")]
    public async Task<ActionResult> consultadashC([FromForm] string jdsucursales, [FromForm] string fecha)
    {
      try
      {
        List<SucursalModel> arrsucursales = System.Text.Json.JsonSerializer.Deserialize<List<SucursalModel>>(jdsucursales);
        string[] datos = fecha.Split('-');
        int year = int.Parse(datos[0]);
        int month = int.Parse(datos[1]);
        List<ComensalesModel> ventassucursales = new List<ComensalesModel>();
        foreach (var itemsuc in arrsucursales)
        {
          ComensalesModel ComensalesSuc = new ComensalesModel();
          ComensalesSuc.ids = itemsuc.cod;
          ComensalesSuc.nombreSucursal = itemsuc.name;
          ComensalesSuc.metacomensales = -1;
          Boolean sinmeta = false;
          var cajafront = _db2Context.RemCajasfronts.Where(x => x.Idfront == itemsuc.cod).FirstOrDefault();
          if (cajafront != null)
          {
            var meta = _db2Context.SerieAns.Where(x => x.SerieAn1 == cajafront.Codalmventas && x.Año == year && x.Mes == month).FirstOrDefault();
            if (meta != null) { ComensalesSuc.metacomensales = (double)(meta.PresupuestoVta / 250); } else { sinmeta = true; }
          }

          double sumaTotal = (double)_db2Context.Albventacabs.Where(x => x.Fo == itemsuc.cod && x.Fecha.Value.Month == month && x.Fecha.Value.Year == year).Sum(x => x.Numcomensales);
          ComensalesSuc.totalcomensales = sumaTotal;
          if (sinmeta)
          {
            ComensalesSuc.cumplimiento = 0;
          }
          else
          {
            ComensalesSuc.cumplimiento = (sumaTotal / ComensalesSuc.metacomensales) * 100;
          }
          ventassucursales.Add(ComensalesSuc);
        }

        return StatusCode(StatusCodes.Status200OK, ventassucursales);

      }
      catch (Exception ex)
      {
        return StatusCode(StatusCodes.Status500InternalServerError, new { message = ex.ToString() });
      }
    }


    [HttpGet]
    [Route("DetallesVentas3/{ids}/{fecha}")]
    public async Task<ActionResult> detallesventas3(int ids, string fecha)
    {
      try
      {
        string[] datos = fecha.Split('-');
        int year = int.Parse(datos[0]);
        int month = int.Parse(datos[1]);
        int diaactual = DateTime.Now.Date.Day;

        int diasdelmes = DateTime.DaysInMonth(year, month);
        double compras = 0, metaventas = 1;

        DetallesVentas3Model detalles3 = new DetallesVentas3Model();

        double costopresupuestado = 44;
        var cajafront = from rf in _db2Context.RemFronts
                        join rcf in _db2Context.RemCajasfronts on rf.Idfront equals rcf.Idfront
                        where rf.Idfront == ids
                        select new
                        {
                          rf.Titulo,
                          rcf.Codalmventas
                        };
        string codalmacen = cajafront.FirstOrDefault().Codalmventas;
        var meta = _db2Context.SerieAns.Where(x => x.SerieAn1 == codalmacen && x.Año == year && x.Mes == month).FirstOrDefault();
        double rotacion = 1;
        if (meta != null)
        {
          rotacion = (double)meta.PresupuestoRotacion;
          metaventas = (double)meta.PresupuestoVta;
        }


        var parametros = _dashboardContext.Parametros.FirstOrDefault();
        if (parametros != null)
        {
          dynamic obj = JsonConvert.DeserializeObject<dynamic>(parametros.Jdata);
          costopresupuestado = (double)obj.costopresupuestado;
        }

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
          connection.Open();

          using (SqlCommand command = new SqlCommand("GET_COMPRAS_SUCURSAL_MES", connection))
          {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@MONTH", month);
            command.Parameters.AddWithValue("@YEAR", year);
            command.Parameters.AddWithValue("@IDS", codalmacen);
            using (SqlDataReader reader = command.ExecuteReader())
            {
              while (reader.Read())
              {
                compras = double.Parse(reader["COMPRAS"].ToString());
              }
            }
          }
        }

        if (DateTime.Now.Date.Year == year && DateTime.Now.Date.Month == month)
        {

        }
        else { diaactual = diasdelmes; }

        double ventareal = (double)_db2Context.Albventacabs.Where(x => x.Fo == ids && x.Fecha.Value.Month == month && x.Fecha.Value.Year == year).Sum(x => x.Totalneto);
        double numcomensales = (double)_db2Context.Albventacabs.Where(x => x.Fo == ids && x.Fecha.Value.Month == month && x.Fecha.Value.Year == year).Sum(x => x.Numcomensales);

        detalles3.ids = ids;
        detalles3.diasdelmes = diasdelmes;
        detalles3.costopresupuestado = costopresupuestado;
        detalles3.ventareal = ventareal;
        detalles3.comprasdelperiodo = compras;
        detalles3.costoreal = (compras / ventareal) * (double)100.00;
        detalles3.rotacionpresupuestada = rotacion;
        detalles3.ticketpromediopresupuestado = (metaventas / rotacion);
        detalles3.rotacionreal = numcomensales;
        detalles3.ticketpromedioreal = (ventareal / numcomensales);
        detalles3.diaactual = diaactual;

        return StatusCode(StatusCodes.Status200OK, detalles3);

      }
      catch (Exception ex)
      {
        return StatusCode(StatusCodes.Status500InternalServerError, new { message = ex.ToString() });
      }
    }


    [HttpGet]
    [Route("DetallesDescuentos/{ids}/{fecha}")]
    public async Task<ActionResult> detallesDescuntos(int ids, string fecha)
    {
      try
      {
        string[] datos = fecha.Split('-');
        int year = int.Parse(datos[0]);
        int month = int.Parse(datos[1]);

        List<DetallesartModel> data = new List<DetallesartModel>();

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
          connection.Open();

          using (SqlCommand command = new SqlCommand("GET_DETALLES_DESCUENTOS_SUCURSAL_MES", connection))
          {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@MONTH", month);
            command.Parameters.AddWithValue("@YEAR", year);
            command.Parameters.AddWithValue("@IDS", ids);
            using (SqlDataReader reader = command.ExecuteReader())
            {
              while (reader.Read())
              {
                data.Add(new DetallesartModel()
                {
                  descripcion = reader["DESCRIPCION"].ToString(),
                  unidades = double.Parse(reader["UNIDADES"].ToString()),
                  importe = double.Parse(reader["IMPORTE"].ToString())
                });
              }
            }
          }
        }

        return StatusCode(StatusCodes.Status200OK, data);

      }
      catch (Exception ex)
      {
        return StatusCode(StatusCodes.Status500InternalServerError, new { message = ex.ToString() });
      }
    }

    [HttpGet]
    [Route("DetallesMermas/{ids}/{fecha}")]
    public async Task<ActionResult> detallesMermas(int ids, string fecha)
    {
      try
      {
        string[] datos = fecha.Split('-');
        int year = int.Parse(datos[0]);
        int month = int.Parse(datos[1]);

        var cajafront = from rf in _db2Context.RemFronts
                        join rcf in _db2Context.RemCajasfronts on rf.Idfront equals rcf.Idfront
                        where rf.Idfront == ids
                        select new
                        {
                          rf.Titulo,
                          rcf.Codalmventas
                        };
        string codalmacen = cajafront.FirstOrDefault().Codalmventas;

        List<DetallesartModel> data = new List<DetallesartModel>();

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
          connection.Open();

          using (SqlCommand command = new SqlCommand("GET_DETALLES_MERMAS_SUCURSAL_MES", connection))
          {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@MONTH", month);
            command.Parameters.AddWithValue("@YEAR", year);
            command.Parameters.AddWithValue("@IDS", codalmacen);
            using (SqlDataReader reader = command.ExecuteReader())
            {
              while (reader.Read())
              {
                data.Add(new DetallesartModel()
                {
                  descripcion = reader["DESCRIPCION"].ToString(),
                  unidades = double.Parse(reader["UNIDADES"].ToString()),
                  importe = double.Parse(reader["IMPORTE"].ToString())
                });
              }
            }
          }
        }

        return StatusCode(StatusCodes.Status200OK, data);

      }
      catch (Exception ex)
      {
        return StatusCode(StatusCodes.Status500InternalServerError, new { message = ex.ToString() });
      }
    }



    [HttpGet]
    [Route("DetallesCancelaciones/{ids}/{fecha}")]
    public async Task<ActionResult> detallesCancelaciones(int ids, string fecha)
    {
      try
      {
        string[] datos = fecha.Split('-');
        int year = int.Parse(datos[0]);
        int month = int.Parse(datos[1]);

        List<DetallesartModel> data = new List<DetallesartModel>();

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
          connection.Open();

          using (SqlCommand command = new SqlCommand("GET_DETALLES_CANCELACIONES_SUCURSAL_MES", connection))
          {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@MONTH", month);
            command.Parameters.AddWithValue("@YEAR", year);
            command.Parameters.AddWithValue("@IDS", ids);
            using (SqlDataReader reader = command.ExecuteReader())
            {
              while (reader.Read())
              {
                data.Add(new DetallesartModel()
                {
                  descripcion = reader["DESCRIPCION"].ToString(),
                  unidades = double.Parse(reader["UNIDADES"].ToString()),
                  importe = double.Parse(reader["IMPORTE"].ToString())
                });
              }
            }
          }
        }

        return StatusCode(StatusCodes.Status200OK, data);

      }
      catch (Exception ex)
      {
        return StatusCode(StatusCodes.Status500InternalServerError, new { message = ex.ToString() });
      }
    }




    [HttpGet]
    [Route("DetallesInvitaciones/{ids}/{fecha}")]
    public async Task<ActionResult> detallesInvitaciones(int ids, string fecha)
    {
      try
      {
        string[] datos = fecha.Split('-');
        int year = int.Parse(datos[0]);
        int month = int.Parse(datos[1]);

        List<DetallesartModel> data = new List<DetallesartModel>();

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
          connection.Open();

          using (SqlCommand command = new SqlCommand("GET_DETALLES_INVITACIONES_SUCURSAL_MES", connection))
          {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@MONTH", month);
            command.Parameters.AddWithValue("@YEAR", year);
            command.Parameters.AddWithValue("@IDS", ids);
            using (SqlDataReader reader = command.ExecuteReader())
            {
              while (reader.Read())
              {
                data.Add(new DetallesartModel()
                {
                  descripcion = reader["DESCRIPCION"].ToString(),
                  unidades = double.Parse(reader["UNIDADES"].ToString()),
                  importe = double.Parse(reader["IMPORTE"].ToString())
                });
              }
            }
          }
        }

        return StatusCode(StatusCodes.Status200OK, data);

      }
      catch (Exception ex)
      {
        return StatusCode(StatusCodes.Status500InternalServerError, new { message = ex.ToString() });
      }
    }



    [HttpGet]
    [Route("DetallesConsumoInterno/{ids}/{fecha}")]
    public async Task<ActionResult> detallesConsumoInterno(int ids, string fecha)
    {
      try
      {
        string[] datos = fecha.Split('-');
        int year = int.Parse(datos[0]);
        int month = int.Parse(datos[1]);

        List<DetallesartModel> data = new List<DetallesartModel>();

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
          connection.Open();

          using (SqlCommand command = new SqlCommand("GET_DETALLES_CONSUMOINTERNO_SUCURSAL_MES", connection))
          {
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@MONTH", month);
            command.Parameters.AddWithValue("@YEAR", year);
            command.Parameters.AddWithValue("@IDS", ids);
            using (SqlDataReader reader = command.ExecuteReader())
            {
              while (reader.Read())
              {
                data.Add(new DetallesartModel()
                {
                  descripcion = reader["DESCRIPCION"].ToString(),
                  unidades = double.Parse(reader["UNIDADES"].ToString()),
                  importe = double.Parse(reader["IMPORTE"].ToString())
                });
              }
            }
          }
        }

        return StatusCode(StatusCodes.Status200OK, data);

      }
      catch (Exception ex)
      {
        return StatusCode(StatusCodes.Status500InternalServerError, new { message = ex.ToString() });
      }
    }



    [HttpGet]
    [Route("inicioAYC/{sucursales}/{fechaini}/{fechafin}")]
    public async Task<ActionResult> getCobrosAYC(string sucursales, string fechaini, string fechafin)
    {
      try
      {
        int[] listsuc = JsonConvert.DeserializeObject<int[]>(sucursales);
        List<CobroAYC> data = new List<CobroAYC>();
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
          connection.Open();

          foreach (var ids in listsuc)
          {
            using (SqlCommand command = new SqlCommand("[dbo].[GET_AYC_COBROS]", connection))
            {

              command.CommandType = CommandType.StoredProcedure;

              // Añadir los parámetros al comando
              command.Parameters.Add(new SqlParameter("@FECHAINI", fechaini));
              command.Parameters.Add(new SqlParameter("@FECHAFIN", fechafin));
              command.Parameters.Add(new SqlParameter("@IDS", ids));

              // Abrir la conexión


              // Ejecutar el comando y leer los resultados
              using (SqlDataReader reader = command.ExecuteReader())
              {
                while (reader.Read())
                {
                  CobroAYC cobroInfo = new CobroAYC
                  {
                    FO = reader["FO"].ToString(),
                    Titulo = reader["TITULO"].ToString(),
                    Descripcion = reader["DESCRIPCION"].ToString(),
                    UdsTotales = Convert.ToInt32(reader["UDSTOTALES"]),
                    UdsPagadas = Convert.ToInt32(reader["UDSPAGADAS"]),
                    Seccion = reader["SECCION"].ToString(),
                    Fecha = Convert.ToDateTime(reader["FECHA"]),
                    Semana = Convert.ToInt32(reader["SEMANA"]),
                    Tipo = reader["TIPO"].ToString(),
                    Orden = Convert.ToInt32(reader["ORDEN"])
                  };
                  data.Add(cobroInfo);
                }
              }


            }

          }
        }


        return StatusCode(StatusCodes.Status200OK, data);
      }
      catch (Exception ex)
      {
        return StatusCode(StatusCodes.Status500InternalServerError, new { message = ex.ToString() });
      }
    }


    [HttpGet]
    [Route("gettiempos/{sucursales}/{fechaini}/{fechafin}/{promini}/{promf}")]
    public async Task<ActionResult> gettiempos(string sucursales, string fechaini, string fechafin, string promini, string promf)
    {
      try
      {
        int[] listsuc = JsonConvert.DeserializeObject<int[]>(sucursales);
        List<TiemposSuc> data = new List<TiemposSuc>();
        using (SqlConnection connection = new SqlConnection(connectionStringDBREBEL))
        {
          connection.Open();


          foreach (var ids in listsuc)
          {

            var suc = _db2Context.RemFronts.Where(x => x.Idfront == ids).FirstOrDefault();
            string nombresuc = suc.Titulo;
            using (SqlCommand command = new SqlCommand("DASHBOARD_TIEMPOSENCOCINA", connection))
            {
              command.CommandTimeout = 1000;
              command.CommandType = CommandType.StoredProcedure;

              // Añadir los parámetros al comando
              command.Parameters.Add(new SqlParameter("@FECHAINI", fechaini));
              command.Parameters.Add(new SqlParameter("@FECHAFIN", fechafin));
              command.Parameters.Add(new SqlParameter("@IDS", nombresuc));
              command.Parameters.Add(new SqlParameter("@PROMINI", promini));
              command.Parameters.Add(new SqlParameter("@PROMF", promf));

              DataSet dt = new DataSet();
              SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
              sqlDataAdapter.Fill(dt);

              DataTable promediodt = dt.Tables[0];

              double promedio = 0;
              if (promediodt.Rows.Count > 0)
              {
                promedio = double.Parse(promediodt.Rows[0][2].ToString());
              }


              DataTable rangosdt = dt.Tables[1];

              List<TiemposRangos> rangos = new List<TiemposRangos>();
              foreach (DataRow item in rangosdt.Rows)
              {
                rangos.Add(new TiemposRangos()
                {
                  rango = item[2].ToString(),
                  total = int.Parse(item[3].ToString()),
                  semana = int.Parse(item[4].ToString())
                });
              }

              data.Add(new TiemposSuc()
              {
                sucursal = nombresuc,
                promedio = promedio,
                rangos = rangos,
              });
            }

          }
        }


        return StatusCode(StatusCodes.Status200OK, data);
      }
      catch (Exception ex)
      {
        return StatusCode(StatusCodes.Status500InternalServerError, new { message = ex.ToString() });
      }
    }

    [HttpPost]
    [Route("getExcelTiemposPromedios")]
    public async Task<ActionResult> getExceltiemposPromedios([FromForm] string data, [FromForm] string promini, [FromForm] string promf)
    {
      try
      {
        List<DataTiemposProm> datap = System.Text.Json.JsonSerializer.Deserialize<List<DataTiemposProm>>(data);

        // Habilitar el licenciamiento de EPPlus
        ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

        // Crear un nuevo paquete de Excel
        using (var package = new ExcelPackage())
        {
          // Agregar una nueva hoja al libro
          var worksheet = package.Workbook.Worksheets.Add("Datos");

          // Definir los encabezados de las columnas
          worksheet.Cells[1, 1].Value = "FECHA INICIAL";
          worksheet.Cells[1, 2].Value = "FECHA FINAL";
          worksheet.Cells[1, 3].Value = "SUCURSAL";
          worksheet.Cells[1, 4].Value = "PROMEDIO";


          // Aplicar formato a los encabezados (opcional)
          using (var range = worksheet.Cells["A1:D1"])
          {
            range.Style.Font.Bold = true;
            range.Style.Fill.PatternType = ExcelFillStyle.Solid;
            range.Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.Black);
            range.Style.Font.Color.SetColor(System.Drawing.Color.White);
          }

          for (int i = 0; i < datap.Count; i++)
          {
            worksheet.Cells[i + 2, 1].Value = promini;
            worksheet.Cells[i + 2, 2].Value = promf;
            worksheet.Cells[i + 2, 3].Value = datap[i].name;
            worksheet.Cells[i + 2, 4].Value = datap[i].value;

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


    [HttpGet]
    [Route("getVentasBebidas/{sucursales}/{fechaini}/{fechafin}")]
    public async Task<ActionResult> getVentasBebidas(string sucursales, string fechaini, string fechafin)
    {
      try
      {
        int[] listsuc = JsonConvert.DeserializeObject<int[]>(sucursales);

        DateTime fecha = DateTime.ParseExact(fechaini, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
        DateTime fecha2 = DateTime.ParseExact(fechafin, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);

        List<(int semana, DateTime inicio, DateTime fin)> semanas = ObtenerSemanasYFechasEnRango(fecha, fecha2);

        List<ventasBebidasModel> data = new List<ventasBebidasModel>();
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
          connection.Open();


          foreach (var ids in listsuc)
          {
            foreach (var itemsem in semanas)
            {
              using (SqlCommand command = new SqlCommand("SPS_CUBORESULTADOS_VENTAS_SUCURSAL", connection))
              {
                command.CommandTimeout = 1000;
                command.CommandType = CommandType.StoredProcedure;

                // Añadir los parámetros al comando
                command.Parameters.Add(new SqlParameter("@AFI", itemsem.inicio));
                command.Parameters.Add(new SqlParameter("@AFF", itemsem.fin));
                command.Parameters.Add(new SqlParameter("@IDS", ids));

                DataSet dt = new DataSet();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
                sqlDataAdapter.Fill(dt);

                DataTable promediodt = dt.Tables[0];

                double promedio = 0;
                promedio = double.Parse(promediodt.Rows[0][2].ToString());

                DataTable datosdt = dt.Tables[0];

                foreach (DataRow item in datosdt.Rows)
                {
                  data.Add(new ventasBebidasModel()
                  {
                    idfront = ids,
                    nombresuc = item[1].ToString(),
                    total = double.Parse(item[2].ToString()),
                    salon = double.Parse(item[3].ToString()),
                    cerveza = double.Parse(item[4].ToString()),
                    rebelitros = double.Parse(item[5].ToString()),
                    semana = itemsem.semana,
                    fi = itemsem.inicio,
                    ff = itemsem.fin
                  });
                }


              }
            }


          }
        }


        return StatusCode(StatusCodes.Status200OK, data);
      }
      catch (Exception ex)
      {
        return StatusCode(StatusCodes.Status500InternalServerError, new { message = ex.ToString() });
      }
    }


    [HttpGet]
    [Route("getPBebidas/{sucursales}/{fechaini}/{fechafin}")]
    public async Task<ActionResult> getPBebidas(string sucursales, string fechaini, string fechafin)
    {
      try
      {
        int[] listsuc = JsonConvert.DeserializeObject<int[]>(sucursales);

        DateTime fecha = DateTime.ParseExact(fechaini, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
        DateTime fecha2 = DateTime.ParseExact(fechafin, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);

        List<(int semana, DateTime inicio, DateTime fin)> semanas = ObtenerSemanasYFechasEnRango(fecha, fecha2);

        List<Object> data = new List<Object>();
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
          connection.Open();

          foreach (int ids in listsuc)
          {
            var sucdb = _db2Context.RemFronts.Where(x => x.Idfront == ids).FirstOrDefault(); 
            foreach (var itemsem in semanas)
            {
               int totalayc = await _fxBonos.getTotalCobrosAYC(ids, itemsem.inicio, itemsem.fin);
              using (SqlCommand command = new SqlCommand("GET_DATA_BEBIDAS_SUC", connection))
              {
                command.CommandTimeout = 1000;
                command.CommandType = CommandType.StoredProcedure;

                // Añadir los parámetros al comando
                command.Parameters.Add(new SqlParameter("@AFI", itemsem.inicio));
                command.Parameters.Add(new SqlParameter("@AFF", itemsem.fin));
                command.Parameters.Add(new SqlParameter("@IDS", ids));

                DataSet dt = new DataSet();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
                sqlDataAdapter.Fill(dt);

                DataTable datosdt = dt.Tables[0];

                data.Add(new
                {
                  idfront = ids,
                  nombresuc = sucdb.Titulo,
                  bebidas = double.Parse(datosdt.Rows[0][2].ToString()),
                  alimentos = double.Parse(datosdt.Rows[0][1].ToString()),
                  semana = itemsem.semana,
                  fi = itemsem.inicio,
                  ff = itemsem.fin,
                  totalayc = totalayc
                });

              }
            }
          }

        }


        return StatusCode(StatusCodes.Status200OK, data);
      }
      catch (Exception ex)
      {
        return StatusCode(StatusCodes.Status500InternalServerError, new { message = ex.ToString() });
      }
    }


    [HttpGet]
    [Route("getMixventas/{sucursales}/{fechaini}/{fechafin}")]
    public async Task<ActionResult> getMixventas(string sucursales, string fechaini, string fechafin)
    {
      try
      {
        int[] listsuc = JsonConvert.DeserializeObject<int[]>(sucursales);

        DateTime fecha = DateTime.ParseExact(fechaini, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
        DateTime fecha2 = DateTime.ParseExact(fechafin, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);


        List<DataMixVentas> data = new List<DataMixVentas>();
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
          connection.Open();

          foreach (var ids in listsuc)
          {
            using (SqlCommand command = new SqlCommand("SPS_MIX_VENTAS", connection))
            {

              command.CommandType = CommandType.StoredProcedure;

              // Añadir los parámetros al comando
              command.Parameters.Add(new SqlParameter("@AFI", fecha));
              command.Parameters.Add(new SqlParameter("@AFF", fecha2));
              command.Parameters.Add(new SqlParameter("@IDS", ids));

              // Abrir la conexión


              // Ejecutar el comando y leer los resultados
              using (SqlDataReader reader = command.ExecuteReader())
              {
                while (reader.Read())
                {
                  DataMixVentas cobroInfo = new DataMixVentas()
                  {
                    ids = ids,
                    sucursal = reader["TITULO"].ToString(),
                    alimentosSalon = double.Parse(reader["S_A"].ToString()),
                    bebidasSalon = double.Parse(reader["S_B"].ToString()),
                    alimentosDelivery = double.Parse(reader["D_A"].ToString()),
                    bebidasDelivery = double.Parse(reader["D_B"].ToString()),
                    alimentosPickup = double.Parse(reader["P_A"].ToString()),
                    bebidasPickup = double.Parse(reader["P_B"].ToString()),
                    semana = int.Parse(reader["SEMANA"].ToString())
                  };
                  data.Add(cobroInfo);
                }
              }


            }

          }
        }


        return StatusCode(StatusCodes.Status200OK, data);
      }
      catch (Exception ex)
      {
        return StatusCode(StatusCodes.Status500InternalServerError, new { message = ex.ToString() });
      }
    }


    //[HttpGet]
    //[Route("get25pts/{sucursales}/{fechaini}/{fechafin}")]
    //public async Task<ActionResult> get25pts(string sucursales, string fechaini, string fechafin)
    //{
    //    try
    //    {
    //        DateTime fecha = DateTime.ParseExact(fechaini, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
    //        DateTime fecha2 = DateTime.ParseExact(fechafin, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);

    //        CultureInfo cultura = CultureInfo.CurrentCulture; // Usa la cultura actual
    //        Calendar calendario = cultura.Calendar;

    //        int[] listsuc = JsonConvert.DeserializeObject<int[]>(sucursales);
    //        List<It25pt> data = new List<It25pt>();

    //        foreach (int ids in listsuc)
    //        {
    //            var sucursal = _db2Context.RemFronts.Where(x => x.Idfront == ids).FirstOrDefault();
    //            if (sucursal != null)
    //            {
    //                var datas = _dbRebelContext.It25pts.Where(x => x.Fechaini.Value.Date >= fecha.Date && x.Fechaini.Value.Date <= fecha2.Date && x.Sucursal == sucursal.Titulo && !x.Justificacion.Equals("prueba")).ToList();
    //                if (datas.Count > 0)
    //                {
    //                    data.AddRange(datas);
    //                }
    //            }
    //        }

    //        List<It25ptDash> data25pts = new List<It25ptDash>();
    //        foreach (var item in data)
    //        {
    //            int numeroSemana = calendario.GetWeekOfYear(
    //            item.Fechaini.Value.Date,
    //            cultura.DateTimeFormat.CalendarWeekRule,
    //            cultura.DateTimeFormat.FirstDayOfWeek);

    //            data25pts.Add(new It25ptDash()
    //            {
    //                Id = item.Id,
    //                Fechaini = item.Fechaini,
    //                Sala = item.Sala,
    //                Mesa = item.Mesa,
    //                TotalAyc = item.TotalAyc,
    //                Cobros = item.Cobros,
    //                CobrosMinimos = item.CobrosMinimos,
    //                Diferencia = item.Diferencia,
    //                Justificacion = item.Justificacion,
    //                Usuario = item.Usuario,
    //                Sucursal = item.Sucursal,
    //                Vendedor = item.Vendedor,
    //                numsemana = numeroSemana,
    //            });
    //        }

    //        return StatusCode(StatusCodes.Status200OK, data25pts);
    //    }
    //    catch (Exception ex)
    //    {
    //        return StatusCode(StatusCodes.Status500InternalServerError, new { message = ex.ToString() });
    //    }
    //}

    [HttpGet]
    [Route("getMermas/{sucursales}/{fechafin}")]
    public async Task<ActionResult> getMermas(string sucursales, string fechafin)
    {
      try
      {
        int[] listsuc = JsonConvert.DeserializeObject<int[]>(sucursales);
        DateTime fechaActual = DateTime.ParseExact(fechafin, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);

        DateTime ultimoDomingo = fechaActual.AddDays(-(int)fechaActual.DayOfWeek - (fechaActual.DayOfWeek == DayOfWeek.Sunday ? 7 : 0));

        // Fecha final (domingo de esta semana)
        DateTime fechaFinal = ultimoDomingo;

        // Fecha final (domingo de esta semana)
        DateTime fechaInicial = ultimoDomingo.AddDays(-7);


        // Cultura que usa semanas que inician en lunes
        CultureInfo cultura = CultureInfo.CurrentCulture;
        Calendar calendario = cultura.Calendar;

        // Configuración para que las semanas inicien en lunes
        CalendarWeekRule reglaSemana = CalendarWeekRule.FirstFourDayWeek;
        DayOfWeek primerDiaSemana = DayOfWeek.Monday;

        // Número de semana
        int numeroSemanaU = calendario.GetWeekOfYear(ultimoDomingo, reglaSemana, primerDiaSemana);

        int[] semanas = new int[8];
        semanas[0] = numeroSemanaU;

        int numresta = -7;
        for (int i = 1; i <= 7; i++)
        {
          semanas[i] = calendario.GetWeekOfYear(ultimoDomingo.AddDays(numresta), reglaSemana, primerDiaSemana);
          numresta = numresta - 7;
        }


        List<MermasDS> mermasdata = new List<MermasDS>();
        List<CompraArt> comprasdata = new List<CompraArt>();

        DateTime fechainim = ultimoDomingo.AddDays(-13);
        DateTime fechafinm = ultimoDomingo;
        int ids = listsuc[0];
        string codalmacen = ids >= 10 ? ids.ToString() : "0" + ids;
        var sucursal = _db2Context.RemFronts.Where(x => x.Idfront == ids).FirstOrDefault(); 

        for (int i = 1; i <= 4; i++)
        {
          double compraala = 0, compraboneless = 0;
          var resultca = from al in _db2Context.Albcompralins
                         join art in _db2Context.Articulos1 on al.Codarticulo equals art.Codarticulo
                         join cab in _db2Context.Albcompracabs on new { al.Numserie, al.Numalbaran, al.N } equals new { cab.Numserie, cab.Numalbaran, cab.N }
                         where cab.Fechaalbaran.Value.Date >= fechainim.Date &&
                               cab.Fechaalbaran.Value.Date <= fechafinm.Date &&
                               al.Codarticulo == 158 &&
                               al.Codalmacen == codalmacen
                         group al by al.Codalmacen into grouped
                         select new
                         {
                           CODALMACEN = grouped.Key,
                           COMPRAS = grouped.Sum(x => x.Unidadestotal)
                         };
          var resultlistca = resultca.ToList();

          if (resultlistca.Count > 0) { compraala = (double)resultlistca[0].COMPRAS; } else { compraala = 0; }


          var resultcb = from al in _db2Context.Albcompralins
                         join art in _db2Context.Articulos1 on al.Codarticulo equals art.Codarticulo
                         join cab in _db2Context.Albcompracabs on new { al.Numserie, al.Numalbaran, al.N } equals new { cab.Numserie, cab.Numalbaran, cab.N }
                         where cab.Fechaalbaran.Value.Date >= fechainim.Date &&
                               cab.Fechaalbaran.Value.Date <= fechafinm.Date &&
                               al.Codarticulo == 10183 &&
                               al.Codalmacen == codalmacen
                         group al by al.Codalmacen into grouped
                         select new
                         {
                           CODALMACEN = grouped.Key,
                           COMPRAS = grouped.Sum(x => x.Unidadestotal)
                         };
          var resultlistcb = resultcb.ToList();

          if (resultlistcb.Count > 0) { compraboneless = (double)resultlistcb[0].COMPRAS; } else { compraboneless = 0; }

          comprasdata.Add(new CompraArt()
          {
            semana = i,
            lblsemana = semanas[i - 1] + " Y " + semanas[i],
            cAla = compraala,
            cBoneless = compraboneless
          });

          var mermasao = _dbRebelContext.ItMermas.Where(x => x.Codarticulo == 158 && x.Fecha.Value.Date >= fechainim.Date && x.Fecha <= fechafinm.Date && x.Justificacion == "MERMA OPERATIVA" && x.Sucursal == sucursal.Titulo).Sum(x => x.Unidades);
          var mermasap = _dbRebelContext.ItMermas.Where(x => x.Codarticulo == 158 && x.Fecha.Value.Date >= fechainim.Date && x.Fecha <= fechafinm.Date && x.Justificacion == "MERMA PROVEEDOR" && x.Sucursal == sucursal.Titulo).Sum(x => x.Unidades);

          var mermasbo = _dbRebelContext.ItMermas.Where(x => x.Codarticulo == 10183 && x.Fecha.Value.Date >= fechainim.Date && x.Fecha <= fechafinm.Date && x.Justificacion == "MERMA OPERATIVA" && x.Sucursal == sucursal.Titulo).Sum(x => x.Unidades);
          var mermasbp = _dbRebelContext.ItMermas.Where(x => x.Codarticulo == 10183 && x.Fecha.Value.Date >= fechainim.Date && x.Fecha <= fechafinm.Date && x.Justificacion == "MERMA PROVEEDOR" && x.Sucursal == sucursal.Titulo).Sum(x => x.Unidades);

          mermasdata.Add(new MermasDS()
          {
            semana = i,
            lblsemana = semanas[i - 1] + " Y " + semanas[i],
            tipo = "MO",
            mermaAla = (double)mermasao,
            mermaBoneless = (double)mermasbo
          });

          mermasdata.Add(new MermasDS()
          {
            semana = i,
            lblsemana = semanas[i - 1] + " Y " + semanas[i],
            tipo = "MP",
            mermaAla = (double)mermasap,
            mermaBoneless = (double)mermasbp
          });

          fechainim = fechainim.AddDays(-7);
          fechafinm = fechafinm.AddDays(-7);

        }


        return StatusCode(StatusCodes.Status200OK,new { mermasdata = mermasdata, comprasdata = comprasdata, numsemanau = semanas});
      }
      catch (Exception ex)
      {
        return StatusCode(StatusCodes.Status500InternalServerError, new { message = ex.ToString() });
      }
    }

    [HttpGet]
    [Route("get25ptsSucursales/{sucursales}/{fechafin}")]
    public async Task<ActionResult> get25ptsSucursales(string sucursales, string fechafin)
    {
      try
      {
        int[] listsuc = JsonConvert.DeserializeObject<int[]>(sucursales);
        DateTime fechaActual = DateTime.ParseExact(fechafin, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);

        DateTime ultimoDomingo = fechaActual.AddDays(-(int)fechaActual.DayOfWeek - (fechaActual.DayOfWeek == DayOfWeek.Sunday ? 7 : 0));

        // Fecha final (domingo de esta semana)
        DateTime fechaFinal = ultimoDomingo;

        // Fecha final (domingo de esta semana)
        DateTime fechaInicial = ultimoDomingo.AddDays(-7);


        // Cultura que usa semanas que inician en lunes
        CultureInfo cultura = CultureInfo.CurrentCulture;
        Calendar calendario = cultura.Calendar;

        // Configuración para que las semanas inicien en lunes
        CalendarWeekRule reglaSemana = CalendarWeekRule.FirstFourDayWeek;
        DayOfWeek primerDiaSemana = DayOfWeek.Monday;

        // Número de semana
        int numeroSemanaU = calendario.GetWeekOfYear(ultimoDomingo.AddDays(7), reglaSemana, primerDiaSemana);
        int numeroSemanaPenultima = calendario.GetWeekOfYear(ultimoDomingo, reglaSemana, primerDiaSemana);

        int[] semanas = new int[9];
        semanas[0] = numeroSemanaU;
        semanas[1] = numeroSemanaPenultima;
        int numresta = -7;
        for (int i = 2; i <= 8; i++)
        {
          semanas[i] = calendario.GetWeekOfYear(ultimoDomingo.AddDays(numresta), reglaSemana, primerDiaSemana);
          numresta = numresta - 7;
        }

        List<Object> data = new List<Object>();
        foreach (var suc in listsuc)
        {
          fechaFinal = ultimoDomingo.AddDays(7);
          fechaInicial = fechaFinal.AddDays(-6);
          int totalayc = 0;
          var front = _db2Context.RemFronts.Where(x => x.Idfront == suc).FirstOrDefault();
          for (int i = 0; i < 8; i++)
          {
            totalayc = await _fx.getTotalAYC(suc, fechaInicial.ToString("yyyy-MM-dd"), fechaFinal.ToString("yyyy-MM-dd"));
            int totalincidencias = _dbRebelContext.It25pts.Where(x => x.Fechaini.Value.Date >= fechaInicial.Date && x.Fechaini.Value.Date <= fechaFinal.Date && x.Sucursal == front.Titulo && !x.Justificacion.Equals("prueba")).ToList().Count;

            data.Add(new
            {
              idf = suc,
              nombresuc = front.Titulo,
              numsemana = semanas[i],
              incidencias = totalincidencias,
              totalayc = totalayc,
            });

            fechaInicial = fechaInicial.AddDays(-7);
            fechaFinal = fechaFinal.AddDays(-7);
          }

        }


        return StatusCode(StatusCodes.Status200OK, new { semanas = semanas, data = data });
      }
      catch (Exception ex)
      {
        return StatusCode(StatusCodes.Status500InternalServerError, new { message = ex.ToString() });
      }
    }


    [HttpGet]
    [Route("get25pts/{sucursales}/{fechaini}/{fechafin}")]
    public async Task<ActionResult> get25pts(string sucursales, string fechaini, string fechafin)
    {
      try
      {

        DateTime fechaActual = DateTime.ParseExact(fechafin, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);

        DateTime ultimoDomingo = fechaActual.AddDays(-(int)fechaActual.DayOfWeek - (fechaActual.DayOfWeek == DayOfWeek.Sunday ? 7 : 0));

        // Fecha final (domingo de esta semana)
        DateTime fechaFinal = ultimoDomingo;

        // Fecha inicial (lunes de hace 8 semanas)
        DateTime fechaInicial = ultimoDomingo.AddDays(-55);

        int[] listsuc = JsonConvert.DeserializeObject<int[]>(sucursales);

        List<Object> listdata = new List<Object>();

        // Cultura que usa semanas que inician en lunes
        CultureInfo cultura = CultureInfo.CurrentCulture;
        Calendar calendario = cultura.Calendar;

        // Configuración para que las semanas inicien en lunes
        CalendarWeekRule reglaSemana = CalendarWeekRule.FirstFourDayWeek;
        DayOfWeek primerDiaSemana = DayOfWeek.Monday;

        // Número de semana
        int numeroSemanaU = calendario.GetWeekOfYear(ultimoDomingo, reglaSemana, primerDiaSemana);


        DateTime fechainim = ultimoDomingo.AddDays(-13);
        DateTime fechafinm = ultimoDomingo;

        int[] semanas = new int[8];
        semanas[0] = numeroSemanaU;

        int numresta = -7;
        for (int i = 1; i <= 7; i++)
        {
          semanas[i] = calendario.GetWeekOfYear(ultimoDomingo.AddDays(numresta), reglaSemana, primerDiaSemana);
          numresta = numresta - 7;
        }

        foreach (int ids in listsuc)
        {
          string codalmacen = ids >= 10 ? ids.ToString() : "0" + ids;
          List<It25pt> data = new List<It25pt>();
          List<Object> datavendedores = new List<Object>();
          var sucursal = _db2Context.RemFronts.Where(x => x.Idfront == ids).FirstOrDefault();
          if (sucursal != null)
          {
            var datas = _dbRebelContext.It25pts.Where(x => x.Fechaini.Value.Date >= fechaInicial.Date && x.Fechaini.Value.Date <= fechaFinal.Date && x.Sucursal == sucursal.Titulo && !x.Justificacion.Equals("prueba") && x.Codvendedor != null).ToList();
            if (datas.Count > 0)
            {
              data.AddRange(datas);
            }

            var vendedores = datas
                               .Select(v => v.Codvendedor) // Seleccionar los nombres
                               .Distinct() // Obtener valores únicos
                               .ToList();

            var vendedoressuc = _db2Context.Albventacabs
            .Where(ac => ac.Fo == ids
                         && ac.Fecha.Value.Date >= fechaInicial.Date
            && ac.Fecha.Value.Date <= fechaFinal.Date)
            .Join(_db2Context.Vendedores,
                  ac => ac.Codvendedor,
                  vd => vd.Codvendedor,
                  (ac, vd) => new { ac.Codvendedor, vd.Nomvendedor, vd.Descatalogado })
            .Where(x => x.Descatalogado == "F")
            .Distinct()
            .Select(x => new
            {
              CodVendedor = x.Codvendedor,
              NomVendedor = x.Nomvendedor
            })
            .ToList();

            foreach (int vend in vendedores)
            {
              var vendedor = vendedoressuc.Where(x => x.CodVendedor == vend).ToList();

              if (vendedor.Count > 0)
              {
                double totalv = 0;
                int totalaycsc = 0;


                  totalv = (double)(totalv + _db2Context.Albventacabs.Where(x => x.Facturado == "T" && x.Fo == ids && x.Fecha.Value.Date >= ultimoDomingo.AddDays(-6).Date && x.Fecha.Value.Date <= ultimoDomingo.Date && x.Codvendedor == vendedor[0].CodVendedor).Sum(t => t.Totalneto));



                  using (SqlConnection connection = new SqlConnection(connectionString))
                  {
                    using (SqlCommand command = new SqlCommand("GET_AYCSCV", connection))
                    {
                      command.CommandType = CommandType.StoredProcedure;

                      // Agregar parámetros
                      command.Parameters.AddWithValue("@FECHAINI", fechaFinal.AddDays(-6));
                      command.Parameters.AddWithValue("@FECHAFIN", fechaFinal);
                      command.Parameters.AddWithValue("@IDS", ids);
                      command.Parameters.AddWithValue("@CODV", vendedor[0].CodVendedor);

                      // Abrir conexión
                      connection.Open();

                      // Ejecutar y leer resultados
                      using (SqlDataReader reader = command.ExecuteReader())
                      {
                        if (reader.Read())
                        {
                          totalaycsc = totalaycsc + reader.GetInt32(reader.GetOrdinal("TOTAL"));
                        }
                      }
                    }
                  }

                fechainim = ultimoDomingo.AddDays(-6);
                fechafinm = ultimoDomingo;

                int[] totalaycvend = new int[8]; 

                for (int i = 0; i < 8; i++)
                {
                  totalaycvend[i] = await _fx.getTotalAYC_V(sucursal.Idfront, fechainim.ToString("yyyy-MM-dd"), fechafinm.ToString("yyyy-MM-dd"), (int)vendedor[0].CodVendedor);
                  fechainim = fechainim.AddDays(-7);
                  fechafinm = fechafinm.AddDays(-7);
                 
                }
                  

                int incidencias = datas.Where(x => x.Codvendedor == vend).ToList().Count();
                int aycsctr = datas.Where(y => y.Cobros == 0 && y.Codvendedor == vend && y.Fechaini.Value.Date >= fechaFinal.AddDays(-6).Date && y.Fechaini.Value.Date <= fechaFinal).ToList().Count;  
                datavendedores.Add(new { vendedor = vendedor[0].NomVendedor, venta = totalv, aycsc = totalaycsc, totalaycv = totalaycvend, aycSinCobroTiempoReal = aycsctr  });
              }
            }
          }

          List<It25ptDash> data25pts = new List<It25ptDash>();
          foreach (var item in data)
          {
            int numsemana = -1;
            if (item.Fechaini.Value.Date >= ultimoDomingo.AddDays(-6).Date && item.Fechaini.Value.Date <= ultimoDomingo.Date)
            {
              numsemana = 1;
            }
            if (item.Fechaini.Value.Date >= ultimoDomingo.AddDays(-13).Date && item.Fechaini.Value.Date <= ultimoDomingo.AddDays(-7).Date)
            {
              numsemana = 2;
            }
            if (item.Fechaini.Value.Date >= ultimoDomingo.AddDays(-20).Date && item.Fechaini.Value.Date <= ultimoDomingo.AddDays(-14).Date)
            {
              numsemana = 3;
            }
            if (item.Fechaini.Value.Date >= ultimoDomingo.AddDays(-27).Date && item.Fechaini.Value.Date <= ultimoDomingo.AddDays(-21).Date)
            {
              numsemana = 4;
            }
            if (item.Fechaini.Value.Date >= ultimoDomingo.AddDays(-34).Date && item.Fechaini.Value.Date <= ultimoDomingo.AddDays(-28).Date)
            {
              numsemana = 5;
            }
            if (item.Fechaini.Value.Date >= ultimoDomingo.AddDays(-41).Date && item.Fechaini.Value.Date <= ultimoDomingo.AddDays(-35).Date)
            {
              numsemana = 6;
            }
            if (item.Fechaini.Value.Date >= ultimoDomingo.AddDays(-48).Date && item.Fechaini.Value.Date <= ultimoDomingo.AddDays(-42).Date)
            {
              numsemana = 7;
            }
            if (item.Fechaini.Value.Date >= ultimoDomingo.AddDays(-55).Date && item.Fechaini.Value.Date <= ultimoDomingo.AddDays(-49).Date)
            {
              numsemana = 8;
            }

            //int numeroSemana = 8 - (int)((fechaFinal - item.Fechaini.Value.Date).TotalDays / 7);

            data25pts.Add(new It25ptDash()
            {
              Id = item.Id,
              Fechaini = item.Fechaini,
              Sala = item.Sala,
              Mesa = item.Mesa,
              TotalAyc = item.TotalAyc,
              Cobros = item.Cobros,
              CobrosMinimos = item.CobrosMinimos,
              Diferencia = item.Diferencia,
              Justificacion = item.Justificacion,
              Usuario = item.Usuario,
              Sucursal = item.Sucursal,
              Vendedor = item.Vendedor,
              numsemana = numsemana,
            });
          }

          List<Object> dataayc = new List<Object>();
          fechainim = ultimoDomingo.AddDays(-6);
          fechafinm = ultimoDomingo;
          for (int i = 0; i < 8; i++)
          {
            int totalincidencias = _dbRebelContext.It25pts.Where(x => x.Fechaini.Value.Date >= fechaInicial.Date && x.Fechaini.Value.Date <= fechaFinal.Date && x.Sucursal == sucursal.Titulo && !x.Justificacion.Equals("prueba")).ToList().Count;

            dataayc.Add(new
            {
              idf = sucursal.Idfront,
              nombresuc = sucursal.Titulo,
              numsemana = semanas[i],
              incidencias = totalincidencias,
            });

            fechaInicial = fechaInicial.AddDays(-7);
            fechaFinal = fechaFinal.AddDays(-7);
          }

          /// MERMAS 

          List<MermasDS> mermasdata = new List<MermasDS>();
          List<CompraArt> comprasdata = new List<CompraArt>();

          for (int i = 1; i <= 4; i++)
          {
            double compraala = 0, compraboneless = 0;
            var resultca = from al in _db2Context.Albcompralins
                           join art in _db2Context.Articulos1 on al.Codarticulo equals art.Codarticulo
                           join cab in _db2Context.Albcompracabs on new { al.Numserie, al.Numalbaran, al.N } equals new { cab.Numserie, cab.Numalbaran, cab.N }
                           where cab.Fechaalbaran.Value.Date >= fechainim.Date &&
                                 cab.Fechaalbaran.Value.Date <= fechafinm.Date &&
                                 al.Codarticulo == 158 &&
                                 al.Codalmacen == codalmacen
                           group al by al.Codalmacen into grouped
                           select new
                           {
                             CODALMACEN = grouped.Key,
                             COMPRAS = grouped.Sum(x => x.Unidadestotal)
                           };
            var resultlistca = resultca.ToList();

            if (resultlistca.Count > 0) { compraala = (double)resultlistca[0].COMPRAS; } else { compraala = 0; }


            var resultcb = from al in _db2Context.Albcompralins
                           join art in _db2Context.Articulos1 on al.Codarticulo equals art.Codarticulo
                           join cab in _db2Context.Albcompracabs on new { al.Numserie, al.Numalbaran, al.N } equals new { cab.Numserie, cab.Numalbaran, cab.N }
                           where cab.Fechaalbaran.Value.Date >= fechainim.Date &&
                                 cab.Fechaalbaran.Value.Date <= fechafinm.Date &&
                                 al.Codarticulo == 10183 &&
                                 al.Codalmacen == codalmacen
                           group al by al.Codalmacen into grouped
                           select new
                           {
                             CODALMACEN = grouped.Key,
                             COMPRAS = grouped.Sum(x => x.Unidadestotal)
                           };
            var resultlistcb = resultcb.ToList();

            if (resultlistcb.Count > 0) { compraboneless = (double)resultlistcb[0].COMPRAS; } else { compraboneless = 0; }

            comprasdata.Add(new CompraArt()
            {
              semana = i,
              lblsemana ="W"+semanas[i] + " Y W" + semanas[i-1],
              cAla = compraala,
              cBoneless = compraboneless
            });

            var mermasao = _dbRebelContext.ItMermas.Where(x => x.Codarticulo == 158 && x.Fecha.Value.Date >= fechainim.Date && x.Fecha <= fechafinm.Date && x.Justificacion == "MERMA OPERATIVA" && x.Sucursal == sucursal.Titulo).Sum(x => x.Unidades);
            var mermasap = _dbRebelContext.ItMermas.Where(x => x.Codarticulo == 158 && x.Fecha.Value.Date >= fechainim.Date && x.Fecha <= fechafinm.Date && x.Justificacion == "MERMA PROVEEDOR" && x.Sucursal == sucursal.Titulo).Sum(x => x.Unidades);

            var mermasbo = _dbRebelContext.ItMermas.Where(x => x.Codarticulo == 10183 && x.Fecha.Value.Date >= fechainim.Date && x.Fecha <= fechafinm.Date && x.Justificacion == "MERMA OPERATIVA" && x.Sucursal == sucursal.Titulo).Sum(x => x.Unidades);
            var mermasbp = _dbRebelContext.ItMermas.Where(x => x.Codarticulo == 10183 && x.Fecha.Value.Date >= fechainim.Date && x.Fecha <= fechafinm.Date && x.Justificacion == "MERMA PROVEEDOR" && x.Sucursal == sucursal.Titulo).Sum(x => x.Unidades);

            mermasdata.Add(new MermasDS()
            {
              semana = i,
              lblsemana = "W" + semanas[i] + " Y W" + semanas[i-1],
              tipo = "MO",
              mermaAla = (double)mermasao,
              mermaBoneless = (double)mermasbo
            });

            mermasdata.Add(new MermasDS()
            {
              semana = i,
              lblsemana = "W" + semanas[i] + " Y W" + semanas[i-1],
              tipo = "MP",
              mermaAla = (double)mermasap,
              mermaBoneless = (double)mermasbp
            });

            fechainim = fechainim.AddDays(-7);
            fechafinm = fechafinm.AddDays(-7);

          }

          // DIFERENCIAS 
          List<Object> comprassemanas = new List<Object>();
          fechainim = ultimoDomingo.AddDays(-7);
          fechafinm = ultimoDomingo;

          for (int i = 1; i <= 8; i++)
          {
            double compraala = 0, compraboneless = 0, comprapapas = 0;
            var resultca = from al in _db2Context.Albcompralins
                           join art in _db2Context.Articulos1 on al.Codarticulo equals art.Codarticulo
                           join cab in _db2Context.Albcompracabs on new { al.Numserie, al.Numalbaran, al.N } equals new { cab.Numserie, cab.Numalbaran, cab.N }
                           where cab.Fechaalbaran.Value.Date >= fechainim.Date &&
                                 cab.Fechaalbaran.Value.Date <= fechafinm.Date &&
                                 al.Codarticulo == 158 &&
                                 al.Codalmacen == codalmacen
                           group al by al.Codalmacen into grouped
                           select new
                           {
                             CODALMACEN = grouped.Key,
                             COMPRAS = grouped.Sum(x => x.Unidadestotal)
                           };
            var resultlistca = resultca.ToList();

            if (resultlistca.Count > 0) { compraala = (double)resultlistca[0].COMPRAS; } else { compraala = 0; }


            var resultcb = from al in _db2Context.Albcompralins
                           join art in _db2Context.Articulos1 on al.Codarticulo equals art.Codarticulo
                           join cab in _db2Context.Albcompracabs on new { al.Numserie, al.Numalbaran, al.N } equals new { cab.Numserie, cab.Numalbaran, cab.N }
                           where cab.Fechaalbaran.Value.Date >= fechainim.Date &&
                                 cab.Fechaalbaran.Value.Date <= fechafinm.Date &&
                                 al.Codarticulo == 10183 &&
                                 al.Codalmacen == codalmacen
                           group al by al.Codalmacen into grouped
                           select new
                           {
                             CODALMACEN = grouped.Key,
                             COMPRAS = grouped.Sum(x => x.Unidadestotal)
                           };
            var resultlistcb = resultcb.ToList();

            var resultcp = from al in _db2Context.Albcompralins
                           join art in _db2Context.Articulos1 on al.Codarticulo equals art.Codarticulo
                           join cab in _db2Context.Albcompracabs on new { al.Numserie, al.Numalbaran, al.N } equals new { cab.Numserie, cab.Numalbaran, cab.N }
                           where cab.Fechaalbaran.Value.Date >= fechainim.Date &&
                                 cab.Fechaalbaran.Value.Date <= fechafinm.Date &&
                                 al.Codarticulo == 10193 &&
                                 al.Codalmacen == codalmacen
                           group al by al.Codalmacen into grouped
                           select new
                           {
                             CODALMACEN = grouped.Key,
                             COMPRAS = grouped.Sum(x => x.Unidadestotal)
                           };
            var resultlistcp = resultcp.ToList();

            fechainim = fechainim.AddDays(-7);
            fechafinm = fechafinm.AddDays(-7);
          }

          // Fecha final (domingo de esta semana)
          fechaFinal = ultimoDomingo;

          // Fecha final (domingo de esta semana)
          fechaInicial = ultimoDomingo.AddDays(-55);

          var diferencias = await _fx.GetDiferencias(ids, fechaInicial.ToString("yyyy-MM-dd"), fechaFinal.ToString("yyyy-MM-dd"));

          diferencias = diferencias.Where(x => semanas.Contains(x.semana)).ToList();

          listdata.Add(new
          {
            data25pts = data25pts,
            datav = datavendedores,
            fechaini = ultimoDomingo.AddDays(-55),
            fechafin = ultimoDomingo,
            datamermas = mermasdata,
            comprasdata = comprasdata,
            numsemanau = semanas,
            datadiferencias = diferencias,
            ids = ids,
            totalesayc = dataayc
          });
        }

        return StatusCode(StatusCodes.Status200OK, listdata);
      }
      catch (Exception ex)
      {
        return StatusCode(StatusCodes.Status500InternalServerError, new { message = ex.ToString() });
      }
    }


    [HttpGet]
    [Route("getPorcentajeInicioAYC/{sucursales}/{fechafin}")]
    public async Task<ActionResult> getPorcentajeInicioayc(string sucursales, string fechafin)
    {
      try
      {
        int[] listsuc = JsonConvert.DeserializeObject<int[]>(sucursales);
        DateTime fechaActual = DateTime.ParseExact(fechafin, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);

        DateTime ultimoDomingo = fechaActual.AddDays(-(int)fechaActual.DayOfWeek - (fechaActual.DayOfWeek == DayOfWeek.Sunday ? 7 : 0));

        // Fecha final (domingo de esta semana)
        DateTime fechaFinal = ultimoDomingo;

        // Fecha final (domingo de esta semana)
        DateTime fechaInicial = ultimoDomingo.AddDays(-7);


        // Cultura que usa semanas que inician en lunes
        CultureInfo cultura = CultureInfo.CurrentCulture;
        Calendar calendario = cultura.Calendar;

        // Configuración para que las semanas inicien en lunes
        CalendarWeekRule reglaSemana = CalendarWeekRule.FirstFourDayWeek;
        DayOfWeek primerDiaSemana = DayOfWeek.Monday;

        // Número de semana
        int numeroSemanaU = calendario.GetWeekOfYear(ultimoDomingo.AddDays(7), reglaSemana, primerDiaSemana);
        int numeroSemanaPenultima = calendario.GetWeekOfYear(ultimoDomingo, reglaSemana, primerDiaSemana);

        int[] semanas = new int[9];
        semanas[0] = numeroSemanaU;
        semanas[1] = numeroSemanaPenultima;
        int numresta = -7;
        for (int i = 2; i <= 8; i++)
        {
          semanas[i] = calendario.GetWeekOfYear(ultimoDomingo.AddDays(numresta), reglaSemana, primerDiaSemana);
          numresta = numresta - 7;
        }

        List<Object> data = new List<Object>();

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
          connection.Open();

          foreach (var suc in listsuc)
          {
            fechaFinal = ultimoDomingo.AddDays(7);
            fechaInicial = fechaFinal.AddDays(-6);
            int totalayc = 0;
            var front = _db2Context.RemFronts.Where(x => x.Idfront == suc).FirstOrDefault();
            for (int i = 0; i < 8; i++)
            {
              List<CobroAYC> dataayc = new List<CobroAYC>();

              using (SqlCommand command = new SqlCommand("[dbo].[GET_AYC_COBROS]", connection))
              {

                command.CommandType = CommandType.StoredProcedure;

                // Añadir los parámetros al comando
                command.Parameters.Add(new SqlParameter("@FECHAINI", fechaInicial.ToString("yyyy-MM-dd")));
                command.Parameters.Add(new SqlParameter("@FECHAFIN", fechaFinal.ToString("yyyy-MM-dd")));
                command.Parameters.Add(new SqlParameter("@IDS", suc));

                // Abrir la conexión


                // Ejecutar el comando y leer los resultados
                using (SqlDataReader reader = command.ExecuteReader())
                {
                  while (reader.Read())
                  {
                    CobroAYC cobroInfo = new CobroAYC
                    {
                      FO = reader["FO"].ToString(),
                      Titulo = reader["TITULO"].ToString(),
                      Descripcion = reader["DESCRIPCION"].ToString(),
                      UdsTotales = Convert.ToInt32(reader["UDSTOTALES"]),
                      UdsPagadas = Convert.ToInt32(reader["UDSPAGADAS"]),
                      Seccion = reader["SECCION"].ToString(),
                      Fecha = Convert.ToDateTime(reader["FECHA"]),
                      Semana = Convert.ToInt32(reader["SEMANA"]),
                      Tipo = reader["TIPO"].ToString(),
                      Orden = Convert.ToInt32(reader["ORDEN"])
                    };
                    dataayc.Add(cobroInfo);
                  }
                }


                data.Add(new
                {
                  idf = suc,
                  nombresuc = front.Titulo,
                  numsemana = semanas[i],
                  incioshb = dataayc.Where(x => x.Tipo == "HOT-DOG" || x.Tipo == "BURGER").ToList().Sum(x=> x.UdsPagadas),
                  totalayc = dataayc.Sum(x => x.UdsTotales),
                });

              }

              fechaInicial = fechaInicial.AddDays(-7);
              fechaFinal = fechaFinal.AddDays(-7);
            }

          }

        }
       


        return StatusCode(StatusCodes.Status200OK, new { semanas = semanas, data = data });
      }
      catch (Exception ex)
      {
        return StatusCode(StatusCodes.Status500InternalServerError, new { message = ex.ToString() });
      }
    }

        [HttpGet]
        [Route("getPorcentajeBebidasRegional/{sucursales}/{fechafin}")]
        public async Task<ActionResult> getPorcentajeBebidasRegional(string sucursales, string fechafin)
        {
            try
            {
                int[] listsuc = JsonConvert.DeserializeObject<int[]>(sucursales);
                DateTime fechaActual = DateTime.ParseExact(fechafin, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);

                DateTime ultimoDomingo = fechaActual.AddDays(-(int)fechaActual.DayOfWeek - (fechaActual.DayOfWeek == DayOfWeek.Sunday ? 7 : 0));

                // Fecha final (domingo de esta semana)
                DateTime fechaFinal = ultimoDomingo;

                // Fecha final (domingo de esta semana)
                DateTime fechaInicial = ultimoDomingo.AddDays(-7);


                // Cultura que usa semanas que inician en lunes
                CultureInfo cultura = CultureInfo.CurrentCulture;
                Calendar calendario = cultura.Calendar;

                // Configuración para que las semanas inicien en lunes
                CalendarWeekRule reglaSemana = CalendarWeekRule.FirstFourDayWeek;
                DayOfWeek primerDiaSemana = DayOfWeek.Monday;

                // Número de semana
                int numeroSemanaU = calendario.GetWeekOfYear(ultimoDomingo.AddDays(7), reglaSemana, primerDiaSemana);
                int numeroSemanaPenultima = calendario.GetWeekOfYear(ultimoDomingo, reglaSemana, primerDiaSemana);

                int[] semanas = new int[9];
                semanas[0] = numeroSemanaU;
                semanas[1] = numeroSemanaPenultima;
                int numresta = -7;
                for (int i = 2; i <= 8; i++)
                {
                    semanas[i] = calendario.GetWeekOfYear(ultimoDomingo.AddDays(numresta), reglaSemana, primerDiaSemana);
                    numresta = numresta - 7;
                }

                List<Object> data = new List<Object>();

                    foreach (var suc in listsuc)
                    {
                        fechaFinal = ultimoDomingo.AddDays(7);
                        fechaInicial = fechaFinal.AddDays(-6);
                        int totalayc = 0;
                        var front = _db2Context.RemFronts.Where(x => x.Idfront == suc).FirstOrDefault();
                        for (int i = 0; i < 8; i++)
                        {
                                PorcentajeBebidaModel porcentajeBeidas = await _fxBonos.getPBebidas(suc, fechaInicial, fechaFinal);
                                data.Add(new
                                {
                                    idf = suc,
                                    nombresuc = front.Titulo,
                                    numsemana = semanas[i],
                                    porcentaje = porcentajeBeidas.porcentaje
                                });

                            fechaInicial = fechaInicial.AddDays(-7);
                            fechaFinal = fechaFinal.AddDays(-7);
                        }

                    }


                return StatusCode(StatusCodes.Status200OK, new { semanas = semanas, data = data });
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new { message = ex.ToString() });
            }
        }

        [HttpGet]
        [Route("getDiferenciasRegional/{sucursales}/{fechafin}")]
        public async Task<ActionResult> getDiferenciasRegional(string sucursales, string fechafin)
        {
            try
            {
                int[] listsuc = JsonConvert.DeserializeObject<int[]>(sucursales);
                DateTime fechaActual = DateTime.ParseExact(fechafin, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);

                DateTime ultimoDomingo = fechaActual.AddDays(-(int)fechaActual.DayOfWeek - (fechaActual.DayOfWeek == DayOfWeek.Sunday ? 7 : 0));

                // Fecha final (domingo de esta semana)
                DateTime fechaFinal = ultimoDomingo;

                // Fecha final (domingo de esta semana)
                DateTime fechaInicial = ultimoDomingo.AddDays(-7);


                // Cultura que usa semanas que inician en lunes
                CultureInfo cultura = CultureInfo.CurrentCulture;
                Calendar calendario = cultura.Calendar;

                // Configuración para que las semanas inicien en lunes
                CalendarWeekRule reglaSemana = CalendarWeekRule.FirstFourDayWeek;
                DayOfWeek primerDiaSemana = DayOfWeek.Monday;

                // Número de semana
                int numeroSemanaU = calendario.GetWeekOfYear(ultimoDomingo.AddDays(7), reglaSemana, primerDiaSemana);
                int numeroSemanaPenultima = calendario.GetWeekOfYear(ultimoDomingo, reglaSemana, primerDiaSemana);

                int[] semanas = new int[9];
                semanas[0] = numeroSemanaU;
                semanas[1] = numeroSemanaPenultima;
                int numresta = -7;
                for (int i = 2; i <= 8; i++)
                {
                    semanas[i] = calendario.GetWeekOfYear(ultimoDomingo.AddDays(numresta), reglaSemana, primerDiaSemana);
                    numresta = numresta - 7;
                }

                List<Object> data = new List<Object>();

                foreach (var suc in listsuc)
                {
                    fechaFinal = ultimoDomingo.AddDays(7);
                    fechaInicial = fechaFinal.AddDays(-6);
                    int totalayc = 0;
                    var front = _db2Context.RemFronts.Where(x => x.Idfront == suc).FirstOrDefault();
                    for (int i = 0; i < 8; i++)
                    {
                        PdiferenciasModel diferenciasData = await _fxBonos.getPDiferencias(suc, fechaInicial, fechaFinal);

                        data.Add(new
                        {
                            idf = suc,
                            nombresuc = front.Titulo,
                            numsemana = semanas[i],
                            pdifAla = diferenciasData.pdifAla,
                            pdifBoneless = diferenciasData.pdifBoneless,
                            pdifPapa = diferenciasData.pdifPapas,
                            alldata = diferenciasData,
                            fechaini = fechaInicial,
                            fechafin = fechaFinal
                        });

                        fechaInicial = fechaInicial.AddDays(-7);
                        fechaFinal = fechaFinal.AddDays(-7);
                    }

                }


                return StatusCode(StatusCodes.Status200OK, new { semanas = semanas, data = data });
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new { message = ex.ToString() });
            }
        }

        [HttpGet]
        [Route("getMermaOperativaRegional/{sucursales}/{fechafin}")]
        public async Task<ActionResult> getMermaOperativaRegional(string sucursales, string fechafin)
        {
            try
            {
                int[] listsuc = JsonConvert.DeserializeObject<int[]>(sucursales);

                DateTime fechaActual = DateTime.ParseExact(fechafin, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);

                DateTime ultimoDomingo = fechaActual.AddDays(-(int)fechaActual.DayOfWeek - (fechaActual.DayOfWeek == DayOfWeek.Sunday ? 7 : 0));

                // Fecha final (domingo de esta semana)
                DateTime fechaFinal = ultimoDomingo;

                // Fecha final (domingo de esta semana)
                DateTime fechaInicial = ultimoDomingo.AddDays(-7);


                // Cultura que usa semanas que inician en lunes
                CultureInfo cultura = CultureInfo.CurrentCulture;
                Calendar calendario = cultura.Calendar;

                // Configuración para que las semanas inicien en lunes
                CalendarWeekRule reglaSemana = CalendarWeekRule.FirstFourDayWeek;
                DayOfWeek primerDiaSemana = DayOfWeek.Monday;

                // Número de semana
                int numeroSemanaU = calendario.GetWeekOfYear(ultimoDomingo.AddDays(7), reglaSemana, primerDiaSemana);
                int numeroSemanaPenultima = calendario.GetWeekOfYear(ultimoDomingo, reglaSemana, primerDiaSemana);

                int[] semanas = new int[9];
                semanas[0] = numeroSemanaU;
                semanas[1] = numeroSemanaPenultima;
                int numresta = -7;
                for (int i = 2; i <= 8; i++)
                {
                    semanas[i] = calendario.GetWeekOfYear(ultimoDomingo.AddDays(numresta), reglaSemana, primerDiaSemana);
                    numresta = numresta - 7;
                }

                List<Object> data = new List<Object>();

                foreach (var suc in listsuc)
                {
                    fechaFinal = ultimoDomingo.AddDays(7);
                    fechaInicial = fechaFinal.AddDays(-6);
                    int totalayc = 0;
                    var front = _db2Context.RemFronts.Where(x => x.Idfront == suc).FirstOrDefault();
                    for (int i = 0; i < 8; i++)
                    {

                        PmermasModel mermasdata = await _fxBonos.getMermasOperativasRegional(suc, fechaInicial, fechaFinal);

                        data.Add(new
                        {
                            idf = suc,
                            nombresuc = front.Titulo,
                            numsemana = semanas[i],
                            pmAla = mermasdata.pmermasAla,
                            pmBoneless = mermasdata.pmermasBoneless,
                            pmPapa = mermasdata.pmermasPapas,
                            alldata = mermasdata,
                            fechaini = fechaInicial,
                            fechafin = fechaFinal
                        });

                        fechaInicial = fechaInicial.AddDays(-7);
                        fechaFinal = fechaFinal.AddDays(-7);
                    }

                }


                return StatusCode(StatusCodes.Status200OK, new { semanas = semanas, data = data });
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new { message = ex.ToString() });
            }
        }

        [HttpPost]
    [Route("getExcelPBebidas")]
    public async Task<ActionResult> getExcelPBebidas([FromForm] string data)
    {
      try
      {
        List<PorcentajeBebidasModel> datap = System.Text.Json.JsonSerializer.Deserialize<List<PorcentajeBebidasModel>>(data);
        int[] semanas = datap.Select(x => x.semana).Distinct().ToArray();
        int[] sucursales = datap.Select(x => x.idfront).Distinct().ToArray();

        // Habilitar el licenciamiento de EPPlus
        ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

        // Crear un nuevo paquete de Excel
        using (var package = new ExcelPackage())
        {
          // Agregar una nueva hoja al libro
          var worksheet = package.Workbook.Worksheets.Add("Datos");

          // Definir los encabezados de las columnas

          int ic = 1;
          for (int i = 1; i <= semanas.Length; i++)
          {
            worksheet.Cells[1, ic].Value = "FECHA INICIAL";
            //
            worksheet.Cells[1, ic].Style.Font.Bold = true;
            worksheet.Cells[1, ic].Style.Fill.PatternType = ExcelFillStyle.Solid;
            worksheet.Cells[1, ic].Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.Black);
            worksheet.Cells[1, ic].Style.Font.Color.SetColor(System.Drawing.Color.White);
            ic++;

            worksheet.Cells[1, ic].Value = "FECHA FINAL";
            worksheet.Cells[1, ic].Style.Font.Bold = true;
            worksheet.Cells[1, ic].Style.Fill.PatternType = ExcelFillStyle.Solid;
            worksheet.Cells[1, ic].Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.Black);
            worksheet.Cells[1, ic].Style.Font.Color.SetColor(System.Drawing.Color.White);
            ic++;

            worksheet.Cells[1, ic].Value = "SEMANA";
            worksheet.Cells[1, ic].Style.Font.Bold = true;
            worksheet.Cells[1, ic].Style.Fill.PatternType = ExcelFillStyle.Solid;
            worksheet.Cells[1, ic].Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.Black);
            worksheet.Cells[1, ic].Style.Font.Color.SetColor(System.Drawing.Color.White);
            ic++;

            worksheet.Cells[1, ic].Value = "SUCURSAL";
            worksheet.Cells[1, ic].Style.Font.Bold = true;
            worksheet.Cells[1, ic].Style.Fill.PatternType = ExcelFillStyle.Solid;
            worksheet.Cells[1, ic].Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.Black);
            worksheet.Cells[1, ic].Style.Font.Color.SetColor(System.Drawing.Color.White);
            ic++;

            worksheet.Cells[1, ic].Value = "AYC COBRADOS";
            worksheet.Cells[1, ic].Style.Font.Bold = true;
            worksheet.Cells[1, ic].Style.Fill.PatternType = ExcelFillStyle.Solid;
            worksheet.Cells[1, ic].Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.Black);
            worksheet.Cells[1, ic].Style.Font.Color.SetColor(System.Drawing.Color.White);
            ic++;
            worksheet.Cells[1, ic].Value = "VENTA BEBIDAS";
            worksheet.Cells[1, ic].Style.Font.Bold = true;
            worksheet.Cells[1, ic].Style.Fill.PatternType = ExcelFillStyle.Solid;
            worksheet.Cells[1, ic].Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.Black);
            worksheet.Cells[1, ic].Style.Font.Color.SetColor(System.Drawing.Color.White);
            ic++;
            worksheet.Cells[1, ic].Value = "% BEBIDAS";
            worksheet.Cells[1, ic].Style.Font.Bold = true;
            worksheet.Cells[1, ic].Style.Fill.PatternType = ExcelFillStyle.Solid;
            worksheet.Cells[1, ic].Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.Black);
            worksheet.Cells[1, ic].Style.Font.Color.SetColor(System.Drawing.Color.White);
            ic++;
            ic++;
          }




          int ir = 2;
          foreach (int ids in sucursales)
          {
            var datasuc = datap.Where(x => x.idfront == ids).ToList();
            ic = 1;
            foreach (int numsem in semanas)
            {
              var datasem = datasuc.Where(x => x.semana == numsem).ToList();
              for (int i = 0; i < datasem.Count; i++)
              {
                worksheet.Cells[ir, ic].Value = datasem[i].fi.Date.ToString("dd/MM/yyyy");
                worksheet.Cells[ir, ic].Style.Numberformat.Format = "dd/MM/yyyy";
                ic++;

                worksheet.Cells[ir, ic].Value = datasem[i].ff.Date.ToString("dd/MM/yyyy");
                worksheet.Cells[ir, ic].Style.Numberformat.Format = "dd/MM/yyyy";
                ic++;

                worksheet.Cells[ir, ic].Value = datasem[i].semana;
                ic++;

                worksheet.Cells[ir, ic].Value = datasem[i].nombresuc;
                ic++;

                worksheet.Cells[ir, ic].Value = datasem[i].totalayc;
                worksheet.Cells[ir, ic].Style.Numberformat.Format = "$#,##0.00";
                ic++;

                worksheet.Cells[ir, ic].Value = datasem[i].bebidas;
                worksheet.Cells[ir, ic].Style.Numberformat.Format = "$#,##0.00";
                ic++;

              
                //double pcervezas = 0, prebelitros = 0;

                //if (datasem[i].cerveza > 0 && datasem[i].salon > 0)
                //{
                //  pcervezas = (datasem[i].cerveza / datasem[i].salon);
                //}

                //if (datasem[i].rebelitros > 0 && datasem[i].salon > 0)
                //{
                //  prebelitros = (datasem[i].rebelitros / datasem[i].salon);
                //}

                double pbebidas = 0;

                if (datasem[i].alimentos > 0 && datasem[i].bebidas > 0)
                {
                  pbebidas = (datasem[i].bebidas / (datasem[i].totalayc * 55));
                }

                worksheet.Cells[ir, ic].Value = pbebidas;
                worksheet.Cells[ir, ic].Style.Numberformat.Format = "#,##0.00";
                if (pbebidas < .40)
                {
                  worksheet.Cells[ir, ic].Style.Fill.PatternType = ExcelFillStyle.Solid;
                  worksheet.Cells[ir, ic].Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.Red);
                  worksheet.Cells[ir, ic].Style.Font.Color.SetColor(System.Drawing.Color.White);
                }

                //if (pcervezas < .25 && pcervezas >= .20)
                //{
                //  worksheet.Cells[ir, ic].Style.Fill.PatternType = ExcelFillStyle.Solid;
                //  worksheet.Cells[ir, ic].Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.Yellow);
                //  worksheet.Cells[ir, ic].Style.Font.Color.SetColor(System.Drawing.Color.Black);
                //}

                if (pbebidas >= .40)
                {
                  worksheet.Cells[ir, ic].Style.Fill.PatternType = ExcelFillStyle.Solid;
                  worksheet.Cells[ir, ic].Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.Green);
                  worksheet.Cells[ir, ic].Style.Font.Color.SetColor(System.Drawing.Color.White);
                }
                //ic++;

                //worksheet.Cells[ir, ic].Value = prebelitros;
                //worksheet.Cells[ir, ic].Style.Numberformat.Format = "0.00%";

                //if (prebelitros < .05)
                //{
                //  worksheet.Cells[ir, ic].Style.Fill.PatternType = ExcelFillStyle.Solid;
                //  worksheet.Cells[ir, ic].Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.Red);
                //  worksheet.Cells[ir, ic].Style.Font.Color.SetColor(System.Drawing.Color.White);
                //}

                //if (prebelitros < .08 && prebelitros >= .05)
                //{
                //  worksheet.Cells[ir, ic].Style.Fill.PatternType = ExcelFillStyle.Solid;
                //  worksheet.Cells[ir, ic].Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.Yellow);
                //  worksheet.Cells[ir, ic].Style.Font.Color.SetColor(System.Drawing.Color.Black);
                //}

                //if (prebelitros >= .08)
                //{
                //  worksheet.Cells[ir, ic].Style.Fill.PatternType = ExcelFillStyle.Solid;
                //  worksheet.Cells[ir, ic].Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.Green);
                //  worksheet.Cells[ir, ic].Style.Font.Color.SetColor(System.Drawing.Color.White);
                //}
                ic++;
                ic++;
              }

            }
            ir++;
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

    static List<(int semana, DateTime inicio, DateTime fin)> ObtenerSemanasYFechasEnRango(DateTime fechaInicial, DateTime fechaFinal)
    {
      // Usar la cultura invariante para obtener el calendario
      CultureInfo cultura = CultureInfo.InvariantCulture;
      Calendar calendario = cultura.Calendar;

      // Usar el formato ISO 8601 para que las semanas empiecen en lunes (esto es opcional)
      CalendarWeekRule reglaSemana = cultura.DateTimeFormat.CalendarWeekRule;
      DayOfWeek primerDiaSemana = DayOfWeek.Monday;

      List<(int semana, DateTime inicio, DateTime fin)> semanas = new List<(int semana, DateTime inicio, DateTime fin)>();

      // Iterar por cada día en el rango de fechas
      DateTime fechaActual = fechaInicial;
      while (fechaActual <= fechaFinal)
      {
        // Obtener el número de semana de la fecha actual
        int numeroSemana = calendario.GetWeekOfYear(fechaActual, reglaSemana, primerDiaSemana);

        // Calcular la fecha de inicio y fin de la semana (ajustar al lunes y domingo)
        DateTime inicioSemana = ObtenerFechaInicioDeSemana(fechaActual, primerDiaSemana);
        DateTime finSemana = inicioSemana.AddDays(6);

        // Asegurarse de que las fechas están dentro del rango especificado
        if (inicioSemana < fechaInicial) inicioSemana = fechaInicial;
        if (finSemana > fechaFinal) finSemana = fechaFinal;

        // Añadir la semana si no ha sido agregada
        if (!semanas.Exists(s => s.semana == numeroSemana))
        {
          semanas.Add((numeroSemana, inicioSemana, finSemana));
        }

        // Avanzar al siguiente día
        fechaActual = fechaActual.AddDays(1);
      }

      return semanas;
    }

    static DateTime ObtenerFechaInicioDeSemana(DateTime fecha, DayOfWeek primerDiaSemana)
    {
      // Restar los días necesarios para ajustar al primer día de la semana (lunes en este caso)
      int offset = fecha.DayOfWeek - primerDiaSemana;
      if (offset < 0) offset += 7; // Si el día actual es antes del primer día de la semana, ajustar
      return fecha.AddDays(-offset);
    }

  }

  public class ventasBebidasModel
  {
    public int idfront { get; set; }
    public string nombresuc { get; set; }
    public double total { get; set; }
    public double salon { get; set; }
    public double cerveza { get; set; }
    public double rebelitros { get; set; }
    public int semana { get; set; }
    public DateTime fi { get; set; }
    public DateTime ff { get; set; }
  }

  public class PorcentajeBebidasModel
  {
    public int idfront { get; set; }
    public string nombresuc { get; set; }
    public double alimentos { get; set; }
    public double bebidas { get; set; }
    public int semana { get; set; }
    public DateTime fi { get; set; }
    public DateTime ff { get; set; }
    public int totalayc { get; set; }
  }

    public class DataMixVentas
  {
    public int ids { get; set; }
    public string sucursal { get; set; }
    public double alimentosSalon { get; set; }
    public double bebidasSalon { get; set; }
    public double alimentosDelivery { get; set; }
    public double bebidasDelivery { get; set; }
    public double alimentosPickup { get; set; }
    public double bebidasPickup { get; set; }
    public int semana { get; set; }
  }




  public class DataTiemposProm
  {
    public string name { get; set; }
    public double value { get; set; }
  }

  public class SucursalModel
  {
    public string name { get; set; }
    public int cod { get; set; }
  }
  public class VentasModel
  {
    public int ids { get; set; }
    public string nombreSucursal { get; set; }
    public double ventaTotal { get; set; }
    public double meta { get; set; }
    public double cumplimiento { get; set; }
    public int month { get; set; }
    public int year { get; set; }
    public double cumplimientoesperado { get; set; }
    public double proyeccion { get; set; }

  }

  public class DetallesVentasModel
  {
    public int ids { get; set; }
    public double ventaTotal { get; set; }
    public double ventasalon { get; set; }
    public double ventapickup { get; set; }
    public double ventauber { get; set; }
    public double ventarappi { get; set; }
    public double ventadidi { get; set; }

    public double uberco { get; set; }
    public double uberfc { get; set; }
    public double uberrw { get; set; }

    public double rappico { get; set; }
    public double rappifc { get; set; }
    public double rappijwi { get; set; }
    public double rappirw { get; set; }
    public double rappiwd { get; set; }

    public double didico { get; set; }
    public double didifc { get; set; }
    public double didijwi { get; set; }
    public double didirw { get; set; }
    public double didiwd { get; set; }

  }

  public class ComensalesModel
  {
    public int ids { get; set; }
    public string nombreSucursal { get; set; }
    public double totalcomensales { get; set; }
    public double metacomensales { get; set; }
    public double cumplimiento { get; set; }

  }

  public class DetallesVentasP2Model
  {
    public int ids { get; set; }

    public double descuentos { get; set; }
    public double mermas { get; set; }
    public double cancelaciones { get; set; }
    public double invitaciones { get; set; }
    public double consumoInterno { get; set; }

  }

  public class DetallesVentas3Model
  {
    public int ids { get; set; }
    public int diasdelmes { get; set; }
    public int diaactual { get; set; }
    public double ventareal { get; set; }
    public double costopresupuestado { get; set; }
    public double costoreal { get; set; }
    public double comprasdelperiodo { get; set; }
    public double ticketpromediopresupuestado { get; set; }
    public double ticketpromedioreal { get; set; }
    public double rotacionpresupuestada { get; set; }
    public double rotacionreal { get; set; }
  }

  public class DetallesartModel
  {
    public string descripcion { get; set; }
    public double unidades { get; set; }
    public double importe { get; set; }
  }

  public class CobroAYC
  {
    public string FO { get; set; }
    public string Titulo { get; set; }
    public string Descripcion { get; set; }
    public int UdsTotales { get; set; }
    public int UdsPagadas { get; set; }
    public string Seccion { get; set; }
    public DateTime Fecha { get; set; }
    public int Semana { get; set; }
    public string Tipo { get; set; }
    public int Orden { get; set; }
  }

  public class TiemposSuc
  {
    public string sucursal { get; set; }
    public double promedio { get; set; }
    public List<TiemposRangos> rangos { get; set; }
  }

  public class TiemposRangos
  {
    public string rango { get; set; }
    public int total { get; set; }
    public int semana { get; set; }

  }

  public partial class It25ptDash
  {
    public int Id { get; set; }
    public DateTime? Fechaini { get; set; }
    public int Sala { get; set; }
    public int Mesa { get; set; }
    public int? TotalAyc { get; set; }
    public int? Cobros { get; set; }
    public int? CobrosMinimos { get; set; }
    public int Diferencia { get; set; }
    public string Justificacion { get; set; } = null!;
    public string? Usuario { get; set; }
    public string Sucursal { get; set; } = null!;
    public string? Vendedor { get; set; }
    public int numsemana { get; set; }
    public int nsa { get; set; }
  }

  public class MermasDS
  {
    public int semana { get; set; }
    public string tipo { get; set; }
    public double mermaAla { get; set; }
    public double mermaBoneless { get; set; }
    public string lblsemana { get; set; }

  }

  public class CompraArt
  {
    public int semana { get; set; }
    public double cAla { get; set; }
    public double cBoneless { get; set; }
    public string lblsemana { get; set; }

  }
}
