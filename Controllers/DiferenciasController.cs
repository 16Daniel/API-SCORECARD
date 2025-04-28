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
using OfficeOpenXml.Style;
using OfficeOpenXml;
using System.Globalization;
using System.Text.Json;

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
        private readonly Funciones.FuncionesBonos _fxBonos;

        public DiferenciasController(BD1Context d1Context, BD2Context bD2Context, DBRebelContext dBRebelContext, IConfiguration configuration, DashboardContext dashboardcontext, Funciones.FuncionesBonos fxBonos)
        {
            _db1Context = d1Context;
            _db2Context = bD2Context;
            _dbRebelContext = dBRebelContext;
            _configuration = configuration;
            connectionString = _configuration.GetConnectionString("DefaultConnection");
            connectionStringDBREBEL = _configuration.GetConnectionString("DBREBELWINGS");
            connectionStringBd2 = _configuration.GetConnectionString("DB2");
            _dashboardContext = dashboardcontext;
            _fxBonos = fxBonos;
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

        [HttpPost]
        [Route("getExcelDiferencias")]
        public async Task<ActionResult> getExcelDiferencias([FromForm] string data,[FromForm]DateTime fechafin)
        {
            try
            {
                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true // Ignora mayúsculas y minúsculas
                };
                List<Reporte> datap = System.Text.Json.JsonSerializer.Deserialize<List<Reporte>>(data,options);
                DateTime[] fechas = datap.Select(x => x.fecha.Date).Distinct().OrderBy(f => f).ToArray();
                string[] sucursales = datap.Select(x => x.cod).Distinct().ToArray();

                // Habilitar el licenciamiento de EPPlus
                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

                // Crear un nuevo paquete de Excel
                using (var package = new ExcelPackage())
                {
                    // Agregar una nueva hoja al libro
                    var worksheet = package.Workbook.Worksheets.Add("Datos");

                    // Definir los encabezados de las columnas

                    //int ic = 1;

                    //    worksheet.Cells[1, ic].Value = "SUCURSAL";
                    //    //
                    //    worksheet.Cells[1, ic].Style.Font.Bold = true;
                    //    worksheet.Cells[1, ic].Style.Fill.PatternType = ExcelFillStyle.Solid;
                    //    worksheet.Cells[1, ic].Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.Black);
                    //    worksheet.Cells[1, ic].Style.Font.Color.SetColor(System.Drawing.Color.White);
                    //    ic++;

                    //    worksheet.Cells[1, ic].Value = "FECHA";
                    //    worksheet.Cells[1, ic].Style.Font.Bold = true;
                    //    worksheet.Cells[1, ic].Style.Fill.PatternType = ExcelFillStyle.Solid;
                    //    worksheet.Cells[1, ic].Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.Black);
                    //    worksheet.Cells[1, ic].Style.Font.Color.SetColor(System.Drawing.Color.White);
                    //    ic++;

                    //    worksheet.Cells[1, ic].Value = "COMPRAS ALA";
                    //    worksheet.Cells[1, ic].Style.Font.Bold = true;
                    //    worksheet.Cells[1, ic].Style.Fill.PatternType = ExcelFillStyle.Solid;
                    //    worksheet.Cells[1, ic].Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.Black);
                    //    worksheet.Cells[1, ic].Style.Font.Color.SetColor(System.Drawing.Color.White);
                    //    ic++;

                    //    worksheet.Cells[1, ic].Value = "DIFERENCIAS ALA";
                    //    worksheet.Cells[1, ic].Style.Font.Bold = true;
                    //    worksheet.Cells[1, ic].Style.Fill.PatternType = ExcelFillStyle.Solid;
                    //    worksheet.Cells[1, ic].Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.Black);
                    //    worksheet.Cells[1, ic].Style.Font.Color.SetColor(System.Drawing.Color.White);
                    //    ic++;

                    //    worksheet.Cells[1, ic].Value = "COMPRAS BONELESS";
                    //    worksheet.Cells[1, ic].Style.Font.Bold = true;
                    //    worksheet.Cells[1, ic].Style.Fill.PatternType = ExcelFillStyle.Solid;
                    //    worksheet.Cells[1, ic].Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.Black);
                    //    worksheet.Cells[1, ic].Style.Font.Color.SetColor(System.Drawing.Color.White);
                    //    ic++;

                    //    worksheet.Cells[1, ic].Value = "DIFERENCIAS BONELESS";
                    //    worksheet.Cells[1, ic].Style.Font.Bold = true;
                    //    worksheet.Cells[1, ic].Style.Fill.PatternType = ExcelFillStyle.Solid;
                    //    worksheet.Cells[1, ic].Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.Black);
                    //    worksheet.Cells[1, ic].Style.Font.Color.SetColor(System.Drawing.Color.White);
                    //    ic++;

                    //    worksheet.Cells[1, ic].Value = "COMPRAS PAPA";
                    //    worksheet.Cells[1, ic].Style.Font.Bold = true;
                    //    worksheet.Cells[1, ic].Style.Fill.PatternType = ExcelFillStyle.Solid;
                    //    worksheet.Cells[1, ic].Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.Black);
                    //    worksheet.Cells[1, ic].Style.Font.Color.SetColor(System.Drawing.Color.White);
                    //    ic++;

                    //    worksheet.Cells[1, ic].Value = "DIFERENCIAS PAPA";
                    //    worksheet.Cells[1, ic].Style.Font.Bold = true;
                    //    worksheet.Cells[1, ic].Style.Fill.PatternType = ExcelFillStyle.Solid;
                    //    worksheet.Cells[1, ic].Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.Black);
                    //    worksheet.Cells[1, ic].Style.Font.Color.SetColor(System.Drawing.Color.White);
                    //    ic++;


                    int ic = 1; int ir = 1;
                    foreach (string ids in sucursales) 
                    {
                        
                        double totalCompraAla = 0,totalCompraBoneless = 0,totalCompraPapa = 0;
                        double totalDifAla = 0, totalDifBoneless = 0, totalDifPapa = 0;

                        ic = 1;
                        worksheet.Cells[ir, ic].Value = "SUCURSAL";
                        worksheet.Cells[ir, ic].Style.Font.Bold = true;
                        worksheet.Cells[ir, ic].Style.Fill.PatternType = ExcelFillStyle.Solid;
                        worksheet.Cells[ir, ic].Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.Black);
                        worksheet.Cells[ir, ic].Style.Font.Color.SetColor(System.Drawing.Color.White);
                        ic++;

                        worksheet.Cells[ir, ic].Value = "FECHA";
                        worksheet.Cells[ir, ic].Style.Font.Bold = true;
                        worksheet.Cells[ir, ic].Style.Fill.PatternType = ExcelFillStyle.Solid;
                        worksheet.Cells[ir, ic].Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.Black);
                        worksheet.Cells[ir, ic].Style.Font.Color.SetColor(System.Drawing.Color.White);
                        ic++;

                        worksheet.Cells[ir, ic].Value = "COMPRAS ALA";
                        worksheet.Cells[ir, ic].Style.Font.Bold = true;
                        worksheet.Cells[ir, ic].Style.Fill.PatternType = ExcelFillStyle.Solid;
                        worksheet.Cells[ir, ic].Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.Black);
                        worksheet.Cells[ir, ic].Style.Font.Color.SetColor(System.Drawing.Color.White);
                        ic++;

                        worksheet.Cells[ir, ic].Value = "DIFERENCIAS ALA";
                        worksheet.Cells[ir, ic].Style.Font.Bold = true;
                        worksheet.Cells[ir, ic].Style.Fill.PatternType = ExcelFillStyle.Solid;
                        worksheet.Cells[ir, ic].Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.Black);
                        worksheet.Cells[ir, ic].Style.Font.Color.SetColor(System.Drawing.Color.White);
                        ic++;

                        worksheet.Cells[ir, ic].Value = "COMPRAS BONELESS";
                        worksheet.Cells[ir, ic].Style.Font.Bold = true;
                        worksheet.Cells[ir, ic].Style.Fill.PatternType = ExcelFillStyle.Solid;
                        worksheet.Cells[ir, ic].Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.Black);
                        worksheet.Cells[ir, ic].Style.Font.Color.SetColor(System.Drawing.Color.White);
                        ic++;

                        worksheet.Cells[ir, ic].Value = "DIFERENCIAS BONELESS";
                        worksheet.Cells[ir, ic].Style.Font.Bold = true;
                        worksheet.Cells[ir, ic].Style.Fill.PatternType = ExcelFillStyle.Solid;
                        worksheet.Cells[ir, ic].Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.Black);
                        worksheet.Cells[ir, ic].Style.Font.Color.SetColor(System.Drawing.Color.White);
                        ic++;

                        worksheet.Cells[ir, ic].Value = "COMPRAS PAPA";
                        worksheet.Cells[ir, ic].Style.Font.Bold = true;
                        worksheet.Cells[ir, ic].Style.Fill.PatternType = ExcelFillStyle.Solid;
                        worksheet.Cells[ir, ic].Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.Black);
                        worksheet.Cells[ir, ic].Style.Font.Color.SetColor(System.Drawing.Color.White);
                        ic++;

                        worksheet.Cells[ir, ic].Value = "DIFERENCIAS PAPA";
                        worksheet.Cells[ir, ic].Style.Font.Bold = true;
                        worksheet.Cells[ir, ic].Style.Fill.PatternType = ExcelFillStyle.Solid;
                        worksheet.Cells[ir, ic].Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.Black);
                        worksheet.Cells[ir, ic].Style.Font.Color.SetColor(System.Drawing.Color.White);
                        ic++;
                        ir++;


                        foreach (var fecha in fechas) 
                        {
                            ic = 1;
                          
                            if (fecha.Date <= fechafin.Date) 
                            {
                                ic = 1;
                                double comprasala = _fxBonos.getComprasArticuloAlm(ids, 158, fecha, fecha);
                                double compraBoneless = _fxBonos.getComprasArticuloAlm(ids, 10183, fecha, fecha);
                                double comprasPapa = _fxBonos.getComprasArticuloAlm(ids, 10193, fecha, fecha);

                                double difAla = 0, difBoneless = 0, difPapa = 0;

                                var reg = datap.Where(x => x.fecha == fecha && x.cod == ids && x.codart == 158).FirstOrDefault();
                                if (reg != null)
                                {
                                    difAla = double.Parse(reg.Diferencia);
                                    totalCompraAla += comprasala;
                                    totalDifAla += difAla;
                                }
                                reg = datap.Where(x => x.fecha == fecha && x.cod == ids && x.codart == 10183).FirstOrDefault();
                                if (reg != null)
                                {
                                    difBoneless = double.Parse(reg.Diferencia);
                                    totalCompraBoneless += compraBoneless;
                                    totalDifBoneless += difBoneless;
                                }
                                reg = datap.Where(x => x.fecha == fecha && x.cod == ids && x.codart == 10193).FirstOrDefault();
                                if (reg != null)
                                {
                                    difPapa = double.Parse(reg.Diferencia);
                                    totalCompraPapa += comprasPapa;
                                    totalDifPapa += difPapa;
                                }

                                worksheet.Cells[ir, ic].Value = reg.Sucursal;
                                ic++;
                                worksheet.Cells[ir, ic].Value = fecha.ToString("dd/MM/yyyy");
                                ic++;
                                worksheet.Cells[ir, ic].Value = comprasala;
                                ic++;
                                worksheet.Cells[ir, ic].Value = difAla;
                                ic++;
                                worksheet.Cells[ir, ic].Value = compraBoneless;
                                ic++;
                                worksheet.Cells[ir, ic].Value = difBoneless;
                                ic++;
                                worksheet.Cells[ir, ic].Value = comprasPapa;
                                ic++;
                                worksheet.Cells[ir, ic].Value = difPapa;
                                ir++;
                            }

                           
                        }

                        ic = 1;

                        worksheet.Cells[ir, ic].Value = "SUCURSAL";
                        worksheet.Cells[ir, ic].Style.Font.Bold = true;
                        worksheet.Cells[ir, ic].Style.Fill.PatternType = ExcelFillStyle.Solid;
                        worksheet.Cells[ir, ic].Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.Yellow);
                        worksheet.Cells[ir, ic].Style.Font.Color.SetColor(System.Drawing.Color.Black);
                        ic++;

                        worksheet.Cells[ir, ic].Value = "COMPRAS ALA";
                        worksheet.Cells[ir, ic].Style.Font.Bold = true;
                        worksheet.Cells[ir, ic].Style.Fill.PatternType = ExcelFillStyle.Solid;
                        worksheet.Cells[ir, ic].Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.Yellow);
                        worksheet.Cells[ir, ic].Style.Font.Color.SetColor(System.Drawing.Color.Black);
                        ic++;

                        worksheet.Cells[ir, ic].Value = "DIFERENCIAS ALA";
                        worksheet.Cells[ir, ic].Style.Font.Bold = true;
                        worksheet.Cells[ir, ic].Style.Fill.PatternType = ExcelFillStyle.Solid;
                        worksheet.Cells[ir, ic].Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.Yellow);
                        worksheet.Cells[ir, ic].Style.Font.Color.SetColor(System.Drawing.Color.Black);
                        ic++;

                        worksheet.Cells[ir, ic].Value = "COMPRAS BONELESS";
                        worksheet.Cells[ir, ic].Style.Font.Bold = true;
                        worksheet.Cells[ir, ic].Style.Fill.PatternType = ExcelFillStyle.Solid;
                        worksheet.Cells[ir, ic].Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.Yellow);
                        worksheet.Cells[ir, ic].Style.Font.Color.SetColor(System.Drawing.Color.Black);
                        ic++;

                        worksheet.Cells[ir, ic].Value = "DIFERENCIAS BONELESS";
                        worksheet.Cells[ir, ic].Style.Font.Bold = true;
                        worksheet.Cells[ir, ic].Style.Fill.PatternType = ExcelFillStyle.Solid;
                        worksheet.Cells[ir, ic].Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.Yellow);
                        worksheet.Cells[ir, ic].Style.Font.Color.SetColor(System.Drawing.Color.Black);
                        ic++;

                        worksheet.Cells[ir, ic].Value = "COMPRAS PAPA";
                        worksheet.Cells[ir, ic].Style.Font.Bold = true;
                        worksheet.Cells[ir, ic].Style.Fill.PatternType = ExcelFillStyle.Solid;
                        worksheet.Cells[ir, ic].Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.Yellow);
                        worksheet.Cells[ir, ic].Style.Font.Color.SetColor(System.Drawing.Color.Black);
                        ic++;

                        worksheet.Cells[ir, ic].Value = "DIFERENCIAS PAPA";
                        worksheet.Cells[ir, ic].Style.Font.Bold = true;
                        worksheet.Cells[ir, ic].Style.Fill.PatternType = ExcelFillStyle.Solid;
                        worksheet.Cells[ir, ic].Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.Yellow);
                        worksheet.Cells[ir, ic].Style.Font.Color.SetColor(System.Drawing.Color.Black);
                        ic++;

                        worksheet.Cells[ir, ic].Value = "% DIFERENCIAS ALA";
                        worksheet.Cells[ir, ic].Style.Font.Bold = true;
                        worksheet.Cells[ir, ic].Style.Fill.PatternType = ExcelFillStyle.Solid;
                        worksheet.Cells[ir, ic].Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.Yellow);
                        worksheet.Cells[ir, ic].Style.Font.Color.SetColor(System.Drawing.Color.Black);
                        ic++;

                        worksheet.Cells[ir, ic].Value = "% DIFERENCIAS BONELESS";
                        worksheet.Cells[ir, ic].Style.Font.Bold = true;
                        worksheet.Cells[ir, ic].Style.Fill.PatternType = ExcelFillStyle.Solid;
                        worksheet.Cells[ir, ic].Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.Yellow);
                        worksheet.Cells[ir, ic].Style.Font.Color.SetColor(System.Drawing.Color.Black);
                        ic++;

                        worksheet.Cells[ir, ic].Value = "% DIFERENCIAS PAPA";
                        worksheet.Cells[ir, ic].Style.Font.Bold = true;
                        worksheet.Cells[ir, ic].Style.Fill.PatternType = ExcelFillStyle.Solid;
                        worksheet.Cells[ir, ic].Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.Yellow);
                        worksheet.Cells[ir, ic].Style.Font.Color.SetColor(System.Drawing.Color.Black);

                        ic = 1;
                        ir++;

                        var reg2 = datap.Where(x => x.cod == ids).FirstOrDefault();
                        worksheet.Cells[ir, ic].Value = reg2.Sucursal;
                        ic++;
                        worksheet.Cells[ir, ic].Value = totalCompraAla;
                        ic++;
                        worksheet.Cells[ir, ic].Value = totalDifAla;
                        ic++;
                        worksheet.Cells[ir, ic].Value = totalCompraBoneless;
                        ic++;
                        worksheet.Cells[ir, ic].Value = totalDifBoneless;
                        ic++;
                        worksheet.Cells[ir, ic].Value = totalCompraPapa;
                        ic++;
                        worksheet.Cells[ir, ic].Value = totalDifPapa;
                        ic++;
                        worksheet.Cells[ir, ic].Value = totalCompraAla == 0 ? 0 : ((totalDifAla / totalCompraAla) * 100); 
                        ic++;
                        worksheet.Cells[ir, ic].Value = totalCompraBoneless == 0 ? 0 : ((totalDifBoneless/totalCompraBoneless)*100);
                        ic++;
                        worksheet.Cells[ir, ic].Value = totalCompraPapa == 0 ? 0 : ((totalDifPapa/totalCompraPapa)*100);
                        ir++;

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
