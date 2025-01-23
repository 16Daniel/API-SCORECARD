using DashboardApi.ModelsBD1;
using DashboardApi.ModelsBD2;
using DashboardApi.ModelsDashboard;
using DashboardApi.ModelsDBRebel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.Data.SqlClient.Server;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Globalization;

namespace DashboardApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiferenciasController : ControllerBase
    {
        BD1Context _db1Context;
        BD2Context _db2Context;
        DBRebelContext _dbRebelContext;
        private readonly IConfiguration _configuration;
        public string connectionString = string.Empty;
        public string connectionStringDBREBEL = string.Empty;
        public string connectionStringBd2 = string.Empty;
        DashboardContext _dashboardContext;


        public DiferenciasController(BD1Context d1Context, BD2Context bD2Context, DBRebelContext dBRebelContext, IConfiguration configuration, DashboardContext dashboardcontext)
        {
            _db1Context = d1Context;
            _db2Context = bD2Context;
            _dbRebelContext = dBRebelContext;
            _configuration = configuration;
            connectionString = _configuration.GetConnectionString("DefaultConnection");
            connectionStringDBREBEL = _configuration.GetConnectionString("DBREBELWINGS");
            connectionStringBd2 = _configuration.GetConnectionString("DB2");
            _dashboardContext = dashboardcontext;
        }

        [HttpGet("getDiferencias/{sucursales}/{fechaini}/{fechafin}")]
        public async Task<ActionResult> GetDiferencias(string sucursales, string fechaini, string fechafin)
        {

            try
            {
                DateTime fecha = DateTime.ParseExact(fechaini, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
                DateTime fecha2 = DateTime.ParseExact(fechafin, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);

                int diasDiferencia = (fecha2 - fecha).Days;
                diasDiferencia++;
                List<Reporte> reportes = new List<Reporte>();
                SqlConnection connection = (SqlConnection)_dashboardContext.Database.GetDbConnection();
                SqlCommand cmd = connection.CreateCommand();
                connection.Open();


                int[] listsuc = JsonConvert.DeserializeObject<int[]>(sucursales);

                foreach (int ids in listsuc) 
                {
                    var cajafront = from rf in _db2Context.RemFronts
                                    join rcf in _db2Context.RemCajasfronts on rf.Idfront equals rcf.Idfront
                                    where rf.Idfront == ids
                                    select new
                                    {
                                        rf.Titulo,
                                        rcf.Codalmventas
                                    };
                    string codalmacen = cajafront.FirstOrDefault().Codalmventas;

                    cmd.Parameters.Clear();
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "GET_DIFERENCIAS";
                    cmd.Parameters.Add("@FECHA", System.Data.SqlDbType.VarChar, 10).Value = fecha.ToString("dd/MM/yyyy");
                    cmd.Parameters.Add("@numdias", System.Data.SqlDbType.Int).Value = diasDiferencia;
                    cmd.Parameters.Add("@IDS", System.Data.SqlDbType.VarChar, 10).Value = codalmacen;
                    cmd.CommandTimeout = 10000;
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Reporte repp = new Reporte();

                        repp.idsuc = ids; 

                        repp.cod = (string)reader["COD"];
                        repp.Region = (string)reader["REGION"];
                        repp.Sucursal = (string)reader["SUCURSAL"];
                        repp.codart = (int)reader["CODART"];
                        repp.Articulo = (string)reader["ARTICULO"];
                        repp.InvAyer = (string)reader["INV_AYER"];
                        repp.InvHoy = (string)reader["INV_HOY"];
                        repp.InvFormula = reader["INV_FORMULA"].ToString();
                        repp.Diferencia = reader["DIFERENCIA"].ToString();
                        repp.fecha = DateTime.ParseExact(reader["FECHA"].ToString().Substring(0, 10), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                        repp.semana = (int)reader["SEMANA"];
                        reportes.Add(repp);
                    }

                    reader.Close();

                }

                connection.Close();

                return StatusCode(StatusCodes.Status200OK, reportes);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new { message = ex.ToString() });
            }

        }


    

    }


    public class Reporte
    {
        public string cod { get; set; }
        public string Region { get; set; }
        public string Sucursal { get; set; }
        public int codart { get; set; }
        public string Articulo { get; set; }
        public string InvAyer { get; set; }
        public string InvHoy { get; set; }
        public string InvFormula { get; set; }
        public string Diferencia { get; set; }

        public DateTime fecha { get; set; } 
        public int semana { get; set; } 
        public int idsuc {  get; set; }

    }


        
}
