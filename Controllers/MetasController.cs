using DashboardApi.ModelsBD1;
using DashboardApi.ModelsBD2;
using DashboardApi.ModelsDashboard;
using DashboardApi.ModelsDBRebel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;
using OfficeOpenXml.Style;

namespace DashboardApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MetasController : ControllerBase
    {
        BD1Context _db1Context; 
        BD2Context _db2Context;
        DBRebelContext _dbRebelContext;
        DashboardContext _dashboardContext; 

        public MetasController(BD1Context d1Context,BD2Context bD2Context, DBRebelContext dBRebelContext, DashboardContext dashboardContext) 
        {
            _db1Context = d1Context;
            _db2Context = bD2Context;
            _dbRebelContext = dBRebelContext;
            _dashboardContext = dashboardContext; 
        }

        [HttpPost("upload")]
        public async Task<IActionResult> UploadFile(IFormFile file)
        {
            try
            {
                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
                if (file == null || file.Length == 0)
                {
                    return BadRequest("No file uploaded.");
                }
                List<MetaModel> sucursales = new List<MetaModel>();

                using (var stream = new MemoryStream())
                {
                    await file.CopyToAsync(stream);
                    using (var package = new ExcelPackage(stream))
                    {
                        var worksheet = package.Workbook.Worksheets[0];
                        var rowCount = worksheet.Dimension.Rows;

                        for (int row = 2; row <= rowCount; row++) // Asumiendo que la primera fila es encabezado
                        {
                            var sucursal = new MetaModel()
                            {
                                Nombre = worksheet.Cells[row, 1].Text,
                                Serie = worksheet.Cells[row, 2].Text,
                                Mes = worksheet.Cells[row, 3].Text,
                                Anio = worksheet.Cells[row, 4].Text,
                                Dias =worksheet.Cells[row, 5].Text,
                                Meta = worksheet.Cells[row, 6].Text,
                                MetaSalon = worksheet.Cells[row, 7].Text,
                                Rotacion = worksheet.Cells[row, 8].Text,
                                Porcentaje = worksheet.Cells[row, 9].Text,
                                Grupo = worksheet.Cells[row, 10].Text
                            };

                            sucursales.Add(sucursal);
                        }
                    }
                }

                return Ok(new { message = "File processed successfully.", data = sucursales });
            }
            catch (Exception ex) 
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message); 
            }
        }

        [HttpPost("GuardarMetas")]
        public async Task<IActionResult> guardarMetas([FromForm] string jdata)
        {
            try
            {
                List<newMetaModel> metas = System.Text.Json.JsonSerializer.Deserialize<List<newMetaModel>>(jdata);

                foreach (var item in metas)
                {
                    int anio = int.Parse(item.anio);
                    int mes = int.Parse(item.mes);
                    if (item.grupo.Trim().Equals("WA"))
                    {
                        var reg = _db2Context.SerieAns.Where(x => x.SerieAn1.Equals(item.serie) && x.Año == anio && x.Mes == mes && x.Grupo == item.grupo).FirstOrDefault();
                        if (reg == null)
                        {
                            _db2Context.SerieAns.Add(new ModelsBD2.SerieAn()
                            {
                                SerieAn1 = item.serie,
                                Mes = mes,
                                Año = anio,
                                Dias = (decimal?)double.Parse(item.dias),
                                PresupuestoVta = (decimal?)double.Parse(item.meta),
                                PresupuestoRotacion = (decimal?)double.Parse(item.rotacion),
                                Porcentaje = (decimal?)double.Parse(item.porcentaje),
                                Grupo = item.grupo,
                            });
                        }
                    }

                    if (item.grupo.Trim().Equals("GAD"))
                    {
                        _db1Context.SerieAns.Add(new ModelsBD1.SerieAn()
                        {
                            SerieAn1 = item.serie,
                            Mes = mes,
                            Año = anio,
                            Dias = (decimal?)double.Parse(item.dias),
                            PresupuestoVta = (decimal?)double.Parse(item.meta),
                            PresupuestoRotacion = (decimal?)double.Parse(item.rotacion),
                            Porcentaje = (decimal?)double.Parse(item.porcentaje),
                            Grupo = item.grupo,
                        });
                    }

                    if (item.grupo == "WA") 
                    {
                        var regMetaSalon = _dashboardContext.MetasSalons.Where(x => x.Año == anio && x.Mes == mes && x.Sucursal == item.serie).FirstOrDefault();
                        if (regMetaSalon == null)
                        {
                            _dashboardContext.MetasSalons.Add(new MetasSalon()
                            {
                                Año = anio,
                                Mes = mes,
                                Meta = double.Parse(item.metaSalon),
                                Sucursal = item.serie
                            });
                        }
                    }
                }
                await _db2Context.SaveChangesAsync();
                await _db1Context.SaveChangesAsync();
                await _dashboardContext.SaveChangesAsync(); 
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpGet("descargarMachote/{fecha}")]
        public async Task<IActionResult> descargarMachote(string fecha)
        {
            try
            {
                string[] datos = fecha.Split('-');
                int year = int.Parse(datos[0]);
                int month = int.Parse(datos[1]);

                int daysInMonth = DateTime.DaysInMonth(year, month);

                var query = from rf in _db2Context.RemFronts
                            join rcf in _db2Context.RemCajasfronts on rf.Idfront equals rcf.Idfront
                            where rcf.Cajafront == 1 && rf.Descatalogado == false
                            select new
                            {
                                rf.Titulo,
                                rcf.Codalmventas
                            };

                var SUCURSALESMX = query.ToList(); 

                // Habilitar el licenciamiento de EPPlus
                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

                // Crear un nuevo paquete de Excel
                using (var package = new ExcelPackage())
                {
                    // Agregar una nueva hoja al libro
                    var worksheet = package.Workbook.Worksheets.Add("Datos");

                    // Definir los encabezados de las columnas
                    worksheet.Cells[1, 1].Value = "SUCURSAL";
                    worksheet.Cells[1, 2].Value = "SERIE";
                    worksheet.Cells[1, 3].Value = "MES";
                    worksheet.Cells[1, 4].Value = "AÑO";
                    worksheet.Cells[1, 5].Value = "DÍAS";
                    worksheet.Cells[1, 6].Value = "META GENERAL";
                    worksheet.Cells[1, 7].Value = "META SALÓN";
                    worksheet.Cells[1, 8].Value = "ROTACIÓN";
                    worksheet.Cells[1, 9].Value = "PORCENTAJE";
                    worksheet.Cells[1, 10].Value = "GRUPO";

                    for (int i = 0; i < SUCURSALESMX.Count; i++) 
                    {
                        worksheet.Cells[i + 2, 1].Value = SUCURSALESMX[i].Titulo;
                        worksheet.Cells[i + 2, 2].Value = SUCURSALESMX[i].Codalmventas;
                        worksheet.Cells[i + 2, 3].Value = month;
                        worksheet.Cells[i + 2, 4].Value = year;
                        worksheet.Cells[i + 2, 5].Value = daysInMonth;
                        worksheet.Cells[i + 2, 6].Value = "";
                        worksheet.Cells[i + 2, 7].Value = "";
                        worksheet.Cells[i + 2, 8].Value = "";
                        worksheet.Cells[i + 2, 9].Value = 3.5;
                        worksheet.Cells[i + 2, 10].Value = "WA";

                    }

                    worksheet.Cells[SUCURSALESMX.Count + 2, 1].Value = "GAD";
                    worksheet.Cells[SUCURSALESMX.Count + 2, 2].Value = "21";
                    worksheet.Cells[SUCURSALESMX.Count + 2, 3].Value = month;
                    worksheet.Cells[SUCURSALESMX.Count + 2, 4].Value = year;
                    worksheet.Cells[SUCURSALESMX.Count + 2, 5].Value = daysInMonth;
                    worksheet.Cells[SUCURSALESMX.Count + 2, 6].Value = "";
                    worksheet.Cells[SUCURSALESMX.Count + 2, 7].Value = "";
                    worksheet.Cells[SUCURSALESMX.Count + 2, 8].Value = "";
                    worksheet.Cells[SUCURSALESMX.Count + 2, 9].Value = 3.5;
                    worksheet.Cells[SUCURSALESMX.Count + 2, 10].Value = "GAD";


                    // Aplicar formato a los encabezados (opcional)
                    using (var range = worksheet.Cells["A1:J1"])
                    {
                        range.Style.Font.Bold = true;
                        range.Style.Fill.PatternType = ExcelFillStyle.Solid;
                        range.Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.Black);
                        range.Style.Font.Color.SetColor(System.Drawing.Color.White);
                    }

                    // Ajustar el ancho de las columnas
                    worksheet.Cells.AutoFitColumns();

                    // Configurar la respuesta HTTP para devolver el archivo de Excel
                    var stream = new MemoryStream();
                    package.SaveAs(stream);
                    stream.Position = 0;

                    var byteArray = stream.ToArray();
                    var base64String = Convert.ToBase64String(byteArray);

                    return Ok(new { base64File = base64String });
                }
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }


    }

    public class MetaModel
    {
        public string Nombre { get; set; }
        public string Serie { get; set; }
        public string Mes { get; set; }
        public string Anio { get; set; }
        public string Dias { get; set; }
        public string Meta { get; set; }
        public string MetaSalon { get; set; }
        public string Rotacion { get; set; }
        public string Porcentaje { get; set; }
        public string Grupo { get; set; }
    }

    public class newMetaModel 
    {
        public string anio { get; set; }
        public string dias { get; set; }
        public string grupo { get; set; }
        public string mes { get; set; }
        public string meta { get; set; }
        public string metaSalon { get; set; }
        public string nombre { get; set; }
        public string porcentaje { get; set; }
        public string rotacion { get; set; }
        public string serie { get; set; }
    }
}
