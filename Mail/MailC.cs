using System.Net.Mail;
using System.Net;
using System.Text;
using OfficeOpenXml;
using System.Drawing;
using System.Data;
using OfficeOpenXml.Style;
using System.Globalization;
using PdfSharpCore.Pdf;
using PdfSharpCore.Drawing;

namespace DashboardApi.Mail
{
    public class MailC
    {
        private readonly IWebHostEnvironment _webHostEnvironment;


        public MailC(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }

        public void EnviarCorreo(MemoryStream file, string bodymail, string asuntop,string filename)
        {
            //// Configurar la información de la cuenta de Gmail
            string correoRemitente = "gilberto.r@operamx.com";
            string contraseña = "GRC1931519315";

            //// Configurar la información de la cuenta de Gmail
            //string correoRemitente = "it_token@operamx.com";
            //string contraseña = "M@5TERKEY";

            // Configurar la información del destinatario
            string correoDestinatario = "enrique.j@operamx.com";
            //string correoDestinatario = "arturo.m@operamx.com";
            string asunto = asuntop; 

            // Configurar el cliente SMTP de Gmail
            SmtpClient clienteSmtp = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential(correoRemitente, contraseña),
                EnableSsl = true,
            };

            // Crear el mensaje de correo
            MailMessage mensaje = new MailMessage(correoRemitente, correoDestinatario, asunto, string.Empty)
            {
                IsBodyHtml = true,
                Body = bodymail,
                SubjectEncoding = Encoding.UTF8,
                BodyEncoding = Encoding.UTF8
            };

            mensaje.Bcc.Add("daniel.h@operamx.com");
            mensaje.To.Add("gilberto.r@operamx.com");
            mensaje.Bcc.Add("arturo.m@operamx.com");
            mensaje.To.Add("carlos.c@operamx.com");
            mensaje.To.Add("adrian.c@operamx.com");
            mensaje.To.Add("jorge.j@operamx.com");
            mensaje.To.Add("ricardo.s@operamx.com");

            // Create the attachment from the MemoryStream
            file.Position = 0; // Ensure the stream position is at the beginning
            var attachment = new Attachment(file,filename, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet");
            mensaje.Attachments.Add(attachment);

            try
            {
                // Enviar el mensaje
                clienteSmtp.Send(mensaje);
                Console.WriteLine("Correo enviado con éxito.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al enviar el correo: {ex.Message}");
            }
            finally
            {
                // Liberar recursos
                mensaje.Dispose();
            }
        }


        public void detallesDifInv(DataSet data, string emailbody,string semana)
        {


            Color colorcelda = ColorTranslator.FromHtml("#00000000");
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            // Crear un nuevo archivo de Excel
            using (var package = new ExcelPackage())
            {
                // Agregar una hoja al libro de trabajo
                var worksheet = package.Workbook.Worksheets.Add("7 DIAS");

                worksheet.Cells[1, 1].Value = "REGION";
                worksheet.Cells[1, 2].Value = "SUCURSAL";
                worksheet.Cells[1, 3].Value = "ARTÍCULO";
                worksheet.Cells[1, 4].Value = "IMPORTE";

                using (var range = worksheet.Cells["A1:D1"])
                {
                    Color colorFondo = ColorTranslator.FromHtml("#00000000");
                    range.Style.Fill.PatternType = ExcelFillStyle.Solid;
                    range.Style.Fill.BackgroundColor.SetColor(colorFondo);
                    range.Style.Font.Color.SetColor(System.Drawing.Color.White);
                    range.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    range.AutoFitColumns();
                }
                int contador = 2;


                DataTable tbl = data.Tables[0];

                for (int i = 0; i < tbl.Rows.Count; i++)
                {
                    worksheet.Cells[contador, 1].Value = tbl.Rows[i][0];
                    worksheet.Cells[contador, 2].Value = tbl.Rows[i][1];
                    worksheet.Cells[contador, 3].Value = tbl.Rows[i][2];
                    worksheet.Cells[contador, 4].Value = tbl.Rows[i][3];

                    contador++;

                }


                using (var range = worksheet.Cells)
                {
                    range.AutoFitColumns();
                }

                // Configurar la respuesta HTTP para devolver el archivo de Excel
                var stream = new MemoryStream();
                package.SaveAs(stream);
                stream.Position = 0;

                // Obtiene la fecha actual
                DateTime fechaActual = DateTime.Now;

                // Obtiene el día actual
                int diaActual = fechaActual.Day;

                string nombreMes = "";
                // Valida si el día actual es 1
                if (diaActual == 1)
                {
                    // Obtiene el mes anterior
                    DateTime mesAnterior = fechaActual.AddMonths(-1);

                    // Formatea el nombre del mes anterior
                    nombreMes = mesAnterior.ToString("MMMM");
                }
                else
                {
                    nombreMes = fechaActual.ToString("MMMM");
                }
                nombreMes = nombreMes.ToUpper();


                //emailbody = emailbody.Replace("--mes", nombreMes);
                EnviarCorreo(stream, emailbody, "DIFERENCIAS DE INVENTARIO CERVEZAS CUAUHTEMOC MOCTEZUMA S.A. DE C.V. / SEMANA " + semana , "DETALLES DIFERENCIAS DE INVENTARIOS.xlsx");

            }
        }


        public void detallesTiempos(DataSet data, string emailbody, string semana)
        {


            Color colorcelda = ColorTranslator.FromHtml("#00000000");
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            // Crear un nuevo archivo de Excel
            using (var package = new ExcelPackage())
            {
                // Agregar una hoja al libro de trabajo
                var worksheet = package.Workbook.Worksheets.Add("DATOS");

                worksheet.Cells[1, 2].Value = "SUCURSAL";
                worksheet.Cells[1, 3].Value = "RANGO";
                worksheet.Cells[1, 4].Value = "TOTAL";
                worksheet.Cells[1, 4].Value = "FECHA";


                using (var range = worksheet.Cells["A1:D1"])
                {
                    Color colorFondo = ColorTranslator.FromHtml("#00000000");
                    range.Style.Fill.PatternType = ExcelFillStyle.Solid;
                    range.Style.Fill.BackgroundColor.SetColor(colorFondo);
                    range.Style.Font.Color.SetColor(System.Drawing.Color.White);
                    range.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    range.AutoFitColumns();
                }
                int contador = 2;


                DataTable tbl = data.Tables[1];

                for (int i = 0; i < tbl.Rows.Count; i++)
                {
                    worksheet.Cells[contador, 1].Value = tbl.Rows[i][0];
                    worksheet.Cells[contador, 2].Value = tbl.Rows[i][1];
                    worksheet.Cells[contador, 3].Value = tbl.Rows[i][2];
                    worksheet.Cells[contador, 4].Value = tbl.Rows[i][3];

                    contador++;

                }


                using (var range = worksheet.Cells)
                {
                    range.AutoFitColumns();
                }

                // Configurar la respuesta HTTP para devolver el archivo de Excel
                var stream = new MemoryStream();
                package.SaveAs(stream);
                stream.Position = 0;

                // Obtiene la fecha actual
                DateTime fechaActual = DateTime.Now;

                // Obtiene el día actual
                int diaActual = fechaActual.Day;

                string nombreMes = "";
                // Valida si el día actual es 1
                if (diaActual == 1)
                {
                    // Obtiene el mes anterior
                    DateTime mesAnterior = fechaActual.AddMonths(-1);

                    // Formatea el nombre del mes anterior
                    nombreMes = mesAnterior.ToString("MMMM");
                }
                else
                {
                    nombreMes = fechaActual.ToString("MMMM");
                }
                nombreMes = nombreMes.ToUpper();


                //emailbody = emailbody.Replace("--mes", nombreMes);
                EnviarCorreo(stream, emailbody, "PROMEDIOS TIEMPOS EN COCINA / SEMANA " + semana, "DETALLES TIEMPOS EN COCINA.xlsx");

            }
        }


        public string GeneratePdf()
        {
            using (MemoryStream ms = new MemoryStream())
            {
                // Crea un documento PDF
                PdfDocument document = new PdfDocument();
                document.Info.Title = "Dashboard Supervisores";

                // Crea una página
                PdfPage page = document.AddPage();

                // Crea un objeto de dibujo para escribir en la página
                XGraphics gfx = XGraphics.FromPdfPage(page);

                // Establecer fuente
                XFont fontTitle = new XFont("Verdana", 20, XFontStyle.Bold);
                XFont fontSubtitle = new XFont("Verdana", 12, XFontStyle.Regular);

                // Dibuja el título
                gfx.DrawString("DASHBOARD SUPERVISORES", fontTitle, XBrushes.Black, new XPoint(220, 50));

                // Dibuja el subtítulo
                gfx.DrawString("ALAMEDA", fontSubtitle, XBrushes.Black, new XPoint(250, 100));

                // Obtiene la ruta física del directorio raíz del contenido
                string contentRootPath = _webHostEnvironment.ContentRootPath;

                // Cargar una imagen (logo)
                XImage logo = XImage.FromFile(contentRootPath+"/Mail/logorebel.png");
                gfx.DrawImage(logo, 20, 20, 100, 50); // Ajusta las dimensiones según sea necesario

                // Guardar el documento en memoria
                document.Save(ms, false);

                // Convierte el arreglo de bytes en Base64
                byte[] pdfBytes = ms.ToArray();
                return Convert.ToBase64String(pdfBytes);
            }
        }


    }

}
