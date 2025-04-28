using DashboardApi.ModelsDashboard;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using SixLabors.ImageSharp;
using System.Xml.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DashboardApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GruposController : ControllerBase
    {
        private DashboardContext _dashboardContext;

       public GruposController(DashboardContext dashboardContext) 
        {
            _dashboardContext = dashboardContext;   
        }


        [HttpGet("getGrupos")]
        public async Task<ActionResult> getGrupos()
        {
            try 
            {
                var lista = _dashboardContext.GruposSucursals.ToList(); 
                return StatusCode(StatusCodes.Status200OK,lista);
            }
            catch(Exception ex)  
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        // POST api/<GruposController>
        [HttpPost("Agregar")]
        public async Task<ActionResult> agregar([FromForm] string nombre, [FromForm] string jdata)
        {
            try
            {
                _dashboardContext.GruposSucursals.Add(new GruposSucursal() 
                {
                    Nombre = nombre,
                    Jdata = jdata
                });
                await _dashboardContext.SaveChangesAsync();
                return StatusCode(StatusCodes.Status200OK);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        // POST api/<GruposController>
        [HttpPost("Actualizar")]
        public async Task<ActionResult> actualizar([FromForm] int id, [FromForm] string nombre, [FromForm] string jdata)
        {
            try
            {
               var reg = _dashboardContext.GruposSucursals.Where(x => x.Id == id).FirstOrDefault();
                if (reg != null) 
                {
                    reg.Nombre = nombre;
                    reg.Jdata = jdata;

                    _dashboardContext.GruposSucursals.Update(reg);
                    await _dashboardContext.SaveChangesAsync();
                }
                return StatusCode(StatusCodes.Status200OK);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }


        // DELETE api/<GruposController>/5
        [HttpDelete("eliminar/{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            try
            {
                var reg = _dashboardContext.GruposSucursals.Where(x => x.Id == id).FirstOrDefault();
                if (reg != null)
                {
                    _dashboardContext.GruposSucursals.Remove(reg);
                    await _dashboardContext.SaveChangesAsync();
                }
                return StatusCode(StatusCodes.Status200OK);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
    }
}
