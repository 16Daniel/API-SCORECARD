using DashboardApi.ModelsBD1;
using DashboardApi.ModelsBD2;
using DashboardApi.ModelsDashboard;
using DashboardApi.ModelsDBRebel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace DashboardApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParametrosController : ControllerBase
    {
        BD1Context _db1Context;
        BD2Context _db2Context;
        DBRebelContext _dbRebelContext;
        private readonly IConfiguration _configuration;
        public string connectionString = string.Empty;
        DashboardContext _dashboardContext; 

        public ParametrosController(BD1Context d1Context, BD2Context bD2Context, DBRebelContext dBRebelContext, IConfiguration configuration, DashboardContext dashboardcontext) 
        {
            _db1Context = d1Context;
            _db2Context = bD2Context;
            _dbRebelContext = dBRebelContext;
            _configuration = configuration;
            connectionString = _configuration.GetConnectionString("DefaultConnection");
            _dashboardContext = dashboardcontext;
        }

        [HttpGet]
        [Route("getData")]
        public async Task<ActionResult> getdata()
        {
            try
            {
                var data = _dashboardContext.Parametros.FirstOrDefault(); 
                return StatusCode(StatusCodes.Status200OK, data);

            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new { message = ex.ToString() });
            }
        }

        [HttpPost]
        [Route("saveData")]
        public async Task<ActionResult> savedata([FromForm] string jdatap)
        {
            try
            {
                var data = _dashboardContext.Parametros.FirstOrDefault();
                if (data == null)
                {
                    _dashboardContext.Parametros.Add(new ModelsDashboard.Parametro() { Jdata = jdatap });
                    await _dashboardContext.SaveChangesAsync();

                }
                else 
                {
                    data.Jdata = jdatap;
                    _dashboardContext.Parametros.Update(data);
                    await _dashboardContext.SaveChangesAsync();
                }
                return StatusCode(StatusCodes.Status200OK);

            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new { message = ex.ToString() });
            }
        }

    }
}
