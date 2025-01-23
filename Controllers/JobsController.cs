using DashboardApi.Mail;
using DashboardApi.ModelsBD1;
using DashboardApi.ModelsBD2;
using DashboardApi.ModelsDashboard;
using DashboardApi.ModelsDBRebel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Globalization;

namespace DashboardApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobsController : ControllerBase
    {

        BD1Context _db1Context;
        BD2Context _db2Context;
        DBRebelContext _dbRebelContext;
        private readonly IConfiguration _configuration;
        public string connectionString = string.Empty;
        public string connectionStringDBREBEL = string.Empty;
        DashboardContext _dashboardContext;
        private readonly MailC _mail; 

        public JobsController(BD1Context d1Context, BD2Context bD2Context, DBRebelContext dBRebelContext, IConfiguration configuration, DashboardContext dashboardcontext,MailC mail)
        {
            _db1Context = d1Context;
            _db2Context = bD2Context;
            _dbRebelContext = dBRebelContext;
            _configuration = configuration;
            connectionString = _configuration.GetConnectionString("DefaultConnection");
            connectionStringDBREBEL = _configuration.GetConnectionString("DBREBELWINGS");
            _dashboardContext = dashboardcontext;
            _mail = mail;
        }


        [HttpPost]
        [Route("JobDiferenciasInventarios")]
        public async Task<ActionResult> jobdiferenciasinv([FromBody]DataModel1 model)
        {
            try
            {
                DateTime fecha = DateTime.ParseExact(model.fecha, "dd/MM/yyyy", CultureInfo.InvariantCulture);

                DateTime fechasp = fecha.AddDays(-7);

                DataSet dt = new DataSet();
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("JOB_DIFERENCIAS_INVENTARIO", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.CommandTimeout = 1000;
                        command.Parameters.AddWithValue("@FECHA", fechasp.ToString("dd/MM/yyyy"));

                        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
                        sqlDataAdapter.Fill(dt);
                    }
                }


                // Crear un objeto Calendar con la configuración regional española
                Calendar calendario = new CultureInfo("es-ES").Calendar;
                int semanaAño = calendario.GetWeekOfYear(fechasp, CalendarWeekRule.FirstFullWeek, DayOfWeek.Monday);

                String mailbody = dt.Tables[1].Rows[0][0].ToString();

                _mail.detallesDifInv(dt,mailbody,semanaAño.ToString());

                _dashboardContext.JobsEjecutados.Add(new JobsEjecutado() 
                {
                    IdJob = 1,
                    Fecha = fecha,
                });

                    await _dashboardContext.SaveChangesAsync();

                return StatusCode(StatusCodes.Status200OK);

            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new { message = ex.ToString() });
            }
        }



        [HttpPost]
        [Route("JobTiemposPormedio")]
        public async Task<ActionResult> jobTiemposPromedio([FromBody] DataModel1 model)
        {
            try
            {
                DateTime fecha = DateTime.ParseExact(model.fecha, "dd/MM/yyyy", CultureInfo.InvariantCulture);

                DateTime fechasp = fecha.AddDays(-7);

                DataSet dt = new DataSet();
                using (SqlConnection connection = new SqlConnection(connectionStringDBREBEL))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("JOB_TIEMPOS_PROMEDIOS", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.CommandTimeout = 1000;
                        command.Parameters.AddWithValue("@FECHAINI", fechasp.ToString("dd/MM/yyyy"));

                        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
                        sqlDataAdapter.Fill(dt);
                    }
                }


                // Crear un objeto Calendar con la configuración regional española
                Calendar calendario = new CultureInfo("es-ES").Calendar;
                int semanaAño = calendario.GetWeekOfYear(fechasp, CalendarWeekRule.FirstFullWeek, DayOfWeek.Monday);

                String mailbody = dt.Tables[0].Rows[0][0].ToString();

                 _mail.detallesTiempos(dt, mailbody, semanaAño.ToString());

                _dashboardContext.JobsEjecutados.Add(new JobsEjecutado()
                {
                    IdJob = 3,
                    Fecha = fecha,
                });

                await _dashboardContext.SaveChangesAsync();

                return StatusCode(StatusCodes.Status200OK);

            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new { message = ex.ToString() });
            }
        }


        [HttpPost]
        [Route("JobCorteMatutino")]
        public async Task<ActionResult> jobcortematutino([FromBody] DataModel1 model)
        {
            try
            {
                DateTime fecha = DateTime.ParseExact(model.fecha, "dd/MM/yyyy", CultureInfo.InvariantCulture);

                DataSet dt = new DataSet();
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("JOB_CORTE_MATUTINO", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.CommandTimeout = 1000;
                        command.Parameters.AddWithValue("@FECHA", fecha.ToString("dd/MM/yyyy"));

                        command.ExecuteNonQuery(); 
                    }
                }

                _dashboardContext.JobsEjecutados.Add(new JobsEjecutado()
                {
                    IdJob = 2,
                    Fecha = fecha,
                });

                await _dashboardContext.SaveChangesAsync();

                return StatusCode(StatusCodes.Status200OK);

            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new { message = ex.ToString() });
            }
        }

        [HttpPost]
        [Route("JobCorteVespertino")]
        public async Task<ActionResult> jobcorteVespertino([FromBody] DataModel1 model)
        {
            try
            {
                DateTime fecha = DateTime.ParseExact(model.fecha, "dd/MM/yyyy", CultureInfo.InvariantCulture);

                DataSet dt = new DataSet();
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("JOB_CORTE_VESPERTINO", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.CommandTimeout = 1000;
                        command.Parameters.AddWithValue("@FECHA", fecha.ToString("dd/MM/yyyy"));

                        command.ExecuteNonQuery();
                    }
                }

                _dashboardContext.JobsEjecutados.Add(new JobsEjecutado()
                {
                    IdJob = 3,
                    Fecha = fecha,
                });

                await _dashboardContext.SaveChangesAsync();

                return StatusCode(StatusCodes.Status200OK);

            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new { message = ex.ToString() });
            }
        }
    }

    public class DataModel1
    {
       public string fecha { get; set; }
    }
}
