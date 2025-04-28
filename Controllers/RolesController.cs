
using DashboardApi.ModelsDashboard;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Text.Json;

namespace API_PEDIDOS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RolesController : ControllerBase
    {
        private readonly ILogger<RolesController> _logger;
        private DashboardContext _dashboardContext;


        public RolesController(ILogger<RolesController> logger, DashboardContext dashboardContext)
        {
            _logger = logger;
            _dashboardContext = dashboardContext;   
        }

        [HttpGet]
        [Route("getRoles")]
        public async Task<ActionResult> GetRoles()
        {
            try
            {
                List<CatRole> roles = new List<CatRole>();
                roles = _dashboardContext.CatRoles.ToList(); 
                return StatusCode(200, roles);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);

                return StatusCode(500, new
                {
                    Success = false,
                    Message = ex.ToString(),
                });
            }
        }

        [HttpGet]
        [Route("getRutas")]
        public async Task<ActionResult> GetRutas()
        {
            try
            {
                List<CatRuta> rutas = new List<CatRuta>();
                rutas = _dashboardContext.CatRutas.ToList();
                return StatusCode(200, rutas);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);

                return StatusCode(500, new
                {
                    Success = false,
                    Message = ex.ToString(),
                });
            }
        }

        [HttpGet]
        [Route("getRutasRol/{idr}")]
        public async Task<ActionResult> GetRutasRol(int idr)
        {
            try
            {
                List<CatRuta> rutas = new List<CatRuta>();
                var idrutas = _dashboardContext.AccesosRutas.Where(x => x.IdRol == idr).ToList();

                foreach (var item in idrutas) 
                {
                    var ruta = _dashboardContext.CatRutas.Where(x => x.Id == item.IdRuta).FirstOrDefault();
                    if (ruta != null) 
                    {
                        rutas.Add(ruta);    
                    }   

                }

                return StatusCode(200, rutas);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);

                return StatusCode(500, new
                {
                    Success = false,
                    Message = ex.ToString(),
                });
            }
        }

        [HttpPost]
        [Route("createRol")]
        public async Task<ActionResult> createrol(CatRole model)
        {
            try
            {
                CatRole newrol = new CatRole() 
                {
                    Descripcion = model.Descripcion,
                };
                _dashboardContext.CatRoles.Add(newrol);
                await _dashboardContext.SaveChangesAsync();  

                return StatusCode(200, new { id = newrol.Id });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);

                return StatusCode(500, new
                {
                    Success = false,
                    Message = ex.ToString(),
                });
            }
        }


        [HttpPost]
        [Route("updateRol")]
        public async Task<ActionResult> updaterol(CatRole model)
        {
            try
            {
                _dashboardContext.CatRoles.Update(model); 
                await _dashboardContext.SaveChangesAsync();
                return StatusCode(200);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);

                return StatusCode(500, new
                {
                    Success = false,
                    Message = ex.ToString(),
                });
            }
        }

        [HttpGet]
        [Route("deleteRol/{id}")]
        public async Task<ActionResult> deleterol(int id)
        {
            try
            {

                var accesos = _dashboardContext.AccesosRutas.Where(x => x.IdRol == id).ToList();
                foreach (var acceso in accesos)
                {
                    _dashboardContext.AccesosRutas.Remove(acceso);
                    await _dashboardContext.SaveChangesAsync();
                }

                var rol = _dashboardContext.CatRoles.Find(id);
                if (rol != null) 
                {
                    _dashboardContext.CatRoles.Remove(rol);
                    await _dashboardContext.SaveChangesAsync();
                }
                return StatusCode(200);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);

                return StatusCode(500, new
                {
                    Success = false,
                    Message = ex.ToString(),
                });
            }
        }

        [HttpPost]
        [Route("saveAccesos")]
        public async Task<ActionResult> saveAccesos([FromForm] string jdata, [FromForm] int idr)
        {
            try
            {  

                var accesos = _dashboardContext.AccesosRutas.Where(x => x.IdRol == idr).ToList();
                foreach (var acceso in accesos) 
                {
                    _dashboardContext.AccesosRutas.Remove(acceso);    
                    await _dashboardContext.SaveChangesAsync();
                }

                int[] intArray = JsonSerializer.Deserialize<int[]>(jdata);

                foreach (var item in intArray) 
                {
                    _dashboardContext.AccesosRutas.Add(new AccesosRuta()
                    {
                        IdRol = idr,
                        IdRuta = item
                    });
                }
                await _dashboardContext.SaveChangesAsync();


                return StatusCode(200);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);

                return StatusCode(500, new
                {
                    Success = false,
                    Message = ex.ToString(),
                });
            }
        }

    }
}
