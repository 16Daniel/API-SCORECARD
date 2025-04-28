using DashboardApi.ModelsBD2;
using Microsoft.Data.SqlClient;
using Newtonsoft.Json;
using Quartz;
using System.Data;
using System.Globalization;
using System.Net.Mail;
using System.Net;
using System.Text;
using DashboardApi.ModelsDashboard;
using Microsoft.Extensions.Configuration;
using DashboardApi.ModelsBD1;

namespace DashboardApi.Mail
{
    public class QuartzHostedService : IHostedService
    {
        private readonly IScheduler _scheduler;

        public QuartzHostedService(IScheduler scheduler)
        {
            _scheduler = scheduler;
        }

        public async Task StartAsync(CancellationToken cancellationToken)
        {
            await _scheduler.Start(cancellationToken);
        }

        public async Task StopAsync(CancellationToken cancellationToken)
        {
            await _scheduler.Shutdown(cancellationToken);
        }
    }


    [DisallowConcurrentExecution]
    public class MainJobs : IJob
    {
        protected BD2Context _contextdb2;
        protected BD1Context _contextdb1;
        public string connectionString = string.Empty;
        DashboardContext _dashboardContext;
        private readonly IConfiguration _configuration;
        private readonly ILogger<MainJobs> _logger;
        private static readonly HttpClient client = new HttpClient();
        string URLBASE = "https://localhost:7165/api/"; 

        public MainJobs(ILogger<MainJobs> logger, BD2Context db2c, IConfiguration configuration, DashboardContext dashboardcontext,BD1Context BDC)
        {
            _logger = logger;
            _contextdb2 = db2c;
            _configuration = configuration;
            connectionString = _configuration.GetConnectionString("DefaultConnection");
            _dashboardContext = dashboardcontext;
            _contextdb1 = BDC;
        }

        public async Task Execute(IJobExecutionContext context)
        {

            try
            {
  
                await ValidarUltimasemanaJ1();
                await ValidarUltimos3diasJ3();
                await ValidarUltimos3diasJ2();
               

            }
            catch (Exception ex)
            {

            }
        }

        public Boolean EjecutarJob(int idj,DateTime fecha)
        {
            Boolean status = false;

            var res = _dashboardContext.JobsEjecutados.Where(x => x.IdJob == idj && x.Fecha.Date == fecha.Date).ToList();

            if (res.Count == 0) 
            {
                status = true;  
            }

            return status;
        }

        public async Task ValidarUltimasemanaJ1() 
        {  
    
            DateTime today = DateTime.Today;
            DateTime lastMonday = today.AddDays(-(int)today.DayOfWeek - 6);

            if (today.DayOfWeek == DayOfWeek.Monday)
            {
                lastMonday = today.AddDays(-7); // Si es lunes, obtener el lunes pasado
                if (DateTime.Now.Hour == 8) 
                {
                    if (EjecutarJob(1, lastMonday))
                    {
                        await EJ_DiferenciasInventarios(lastMonday.ToString("dd/MM/yyyy"));
                    }
                }
            }
            else 
            {

                if (EjecutarJob(1, lastMonday))
                {
                    await EJ_DiferenciasInventarios(lastMonday.ToString("dd/MM/yyyy"));
                }
            }

            
        }

        public async Task ValidarUltimos3diasJ2()
        {
            DateTime fecha = DateTime.Now;
            fecha = fecha.AddDays(-2);
            if (transaccionesencola() == false) 
            {
                for (int i = 0; i < 3; i++)
                {
                    if (fecha.Date == DateTime.Now.Date)
                    {
                        if (DateTime.Now.Hour > 19) 
                        {
                            if (EjecutarJob(1, fecha))
                            {
                                await EJ_corteMatutino(fecha.ToString("dd/MM/yyyy"));
                            }
                        }
                    }
                    else 
                    {
                        if (EjecutarJob(2, fecha))
                        {
                            await EJ_corteMatutino(fecha.ToString("dd/MM/yyyy"));
                        }
                    }

                    fecha = fecha.AddDays(1);

                }
            }
        }

        public async Task ValidarUltimos3diasJ3()
        {
            DateTime fecha = DateTime.Now;
            fecha = fecha.AddDays(-2);
            if (transaccionesencola() == false)
            {
                for (int i = 0; i < 3; i++)
                {
                    if (fecha.Date == DateTime.Now.Date)
                    {
                        if (DateTime.Now.Hour > 6)
                        {
                            if (EjecutarJob(1, fecha))
                            {
                                await EJ_corteVespertino(fecha.ToString("dd/MM/yyyy"));
                            }
                        }
                    }
                    else
                    {
                        if (EjecutarJob(2, fecha))
                        {
                            await EJ_corteVespertino(fecha.ToString("dd/MM/yyyy"));
                        }
                    }

                    fecha = fecha.AddDays(1);

                }
            }
        }

        public Boolean transaccionesencola()
        {
            Boolean status = false; 
            var transaccionesQro = _contextdb1.RemControlreplicacions.Where(x => x.Transcola >=10).ToList();
            var transaccionesCdmx = _contextdb2.RemControlreplicacions.Where(x => x.Transcola >= 10).ToList();

            if (transaccionesQro.Count > 0 || transaccionesCdmx.Count > 0) 
            {
                status = true;
            }

            return status;

        }


        public async Task EJ_corteMatutino(string fecha) 
        {

            try
            {
                DateTime fechahoy = DateTime.Now;
                var data = new
                {
                    fecha = fecha
                };

                string url = URLBASE + "Jobs/JobCorteMatutino";
                var jsonData = JsonConvert.SerializeObject(data);
                var content = new StringContent(jsonData, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await client.PostAsync(url, content);

            }
            catch (Exception ex)
            {

            }
        }

        public async Task EJ_corteVespertino(string fecha)
        {

            try
            {
                DateTime fechahoy = DateTime.Now;
                var data = new
                {
                    fecha = fecha
                };

                string url = URLBASE + "Jobs/JobCorteVespertino";
                var jsonData = JsonConvert.SerializeObject(data);
                var content = new StringContent(jsonData, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await client.PostAsync(url, content);

            }
            catch (Exception ex)
            {

            }
        }

        public async Task EJ_DiferenciasInventarios(string fecha) 
        {
            try
            {
                DateTime fechahoy = DateTime.Now;
                var data = new
                {
                    fecha = fecha
                };

                string url = URLBASE + "Jobs/JobDiferenciasInventarios";
                var jsonData = JsonConvert.SerializeObject(data);
                var content = new StringContent(jsonData, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await client.PostAsync(url, content);

            }
            catch (Exception ex)
            {

            }
        }

    }

}
