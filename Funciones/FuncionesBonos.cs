using DashboardApi.Controllers;
using DashboardApi.ModelsBD1;
using DashboardApi.ModelsBD2;
using DashboardApi.ModelsDashboard;
using DashboardApi.ModelsDBRebel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic;
using SixLabors.ImageSharp;
using System.Data;
using System.Diagnostics.Metrics;
using System.Text.Json;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace DashboardApi.Funciones
{
    public class FuncionesBonos
    {
        BD1Context _db1Context;
        BD2Context _db2Context;
        DBRebelContext _dbRebelContext;
        private readonly IConfiguration _configuration;
        public string connectionString = string.Empty;
        public string connectionStringDBREBEL = string.Empty;
        public string connectionStringBd2 = string.Empty;
        DashboardContext _dashboardContext;
        private readonly Funciones _fx;

        public FuncionesBonos(BD1Context d1Context, BD2Context bD2Context, DBRebelContext dBRebelContext, IConfiguration configuration, DashboardContext dashboardcontext, Funciones fx)
        {
            _db1Context = d1Context;
            _db2Context = bD2Context;
            _dbRebelContext = dBRebelContext;
            _configuration = configuration;
            connectionString = _configuration.GetConnectionString("DefaultConnection");
            connectionStringDBREBEL = _configuration.GetConnectionString("DBREBELWINGS");
            connectionStringBd2 = _configuration.GetConnectionString("DB2");
            _dashboardContext = dashboardcontext;
            _fx = fx;
        }

        public async Task<VentasModel> AlcanceDeVentas(int itemsuc, string mes) 
        {
            VentasModel ventaSuc = new VentasModel();
            try 
            {
                var sucursal = _db2Context.RemFronts.Where(x => x.Idfront == itemsuc).FirstOrDefault();
                string[] datos = mes.Split('/');
                int year = int.Parse(datos[1]);
                int month = int.Parse(datos[0]);

                ventaSuc.ids = sucursal.Idfront;
                ventaSuc.nombreSucursal = sucursal.Titulo;
                ventaSuc.meta = -1;
                Boolean sinmeta = false;
                var cajafront = _db2Context.RemCajasfronts.Where(x => x.Idfront == sucursal.Idfront).FirstOrDefault();
                if (cajafront != null)
                {
                    var meta = _db2Context.SerieAns.Where(x => x.SerieAn1 == cajafront.Codalmventas && x.Año == year && x.Mes == month).FirstOrDefault();
                    if (meta != null) { ventaSuc.meta = (double)meta.PresupuestoVta; } else { sinmeta = true; }
                }

                double sumaTotalNeto = (double)_db2Context.Albventacabs.Where(x => x.Fo == sucursal.Idfront && x.Fecha.Value.Month == month && x.Fecha.Value.Year == year).Sum(x => x.Totalneto);
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

                return ventaSuc; 
            }catch (Exception ex) 
            {
                return ventaSuc;
            }
        }

        public async Task<costoModel> getCosto(VentasModel data)
        {
            costoModel costosucursal = new costoModel();
            try
            {
                double compras = 0;
                var cajafront = from rf in _db2Context.RemFronts
                                join rcf in _db2Context.RemCajasfronts on rf.Idfront equals rcf.Idfront
                                where rf.Idfront == data.ids
                                select new
                                {
                                    rf.Titulo,
                                    rcf.Codalmventas
                                };
                string codalmacen = cajafront.FirstOrDefault().Codalmventas;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("GET_COMPRAS_SUCURSAL_MES", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@MONTH", data.month);
                        command.Parameters.AddWithValue("@YEAR", data.year);
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

                costosucursal.ids = data.ids;
                costosucursal.compras = compras;
                costosucursal.costo = data.ventaTotal >0 ? (compras / data.ventaTotal) * (double)100.00 : 0;
                return costosucursal;
            }
            catch (Exception ex)
            {
                return costosucursal;
            }
        }

        public async Task<PorcentajeBebidaModel> getPBebidas(int ids,DateTime fechaini, DateTime fechafin)
        {
            int totalayc = await getTotalCobrosAYC(ids, fechaini, fechafin); 
             PorcentajeBebidaModel data = new PorcentajeBebidaModel();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("GET_DATA_BEBIDAS_SUC", connection))
                    {
                        //command.CommandTimeout = 10000;
                        command.CommandType = CommandType.StoredProcedure;

                        // Añadir los parámetros al comando
                        command.Parameters.Add(new SqlParameter("@AFI", fechaini));
                        command.Parameters.Add(new SqlParameter("@AFF", fechafin));
                        command.Parameters.Add(new SqlParameter("@IDS", ids));

                        DataSet dt = new DataSet();
                        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
                        sqlDataAdapter.Fill(dt);

                        DataTable datosdt = dt.Tables[0];

                        double ventaAlimentosSalon = double.Parse(datosdt.Rows[0][1].ToString());
                        double ventaBebidasSalon = double.Parse(datosdt.Rows[0][2].ToString());
                        data.ventaAlimentosSalon = ventaAlimentosSalon;
                        data.ventaBebidasSalon = ventaBebidasSalon;
                        data.totalAYC = totalayc; 
                        data.porcentaje = totalayc>0 ? (ventaBebidasSalon /(totalayc*55)) :0;

                    }
                }
               
                return data; 
            }
            catch (Exception ex)
            {
                return data;
            }
        }

        public async Task<int> getTotalCobrosAYC(int ids, DateTime fechaini, DateTime fechafin)
        {
            int data = 0;
            try
            {
                List<CobroAYC> dataAYC = new List<CobroAYC>();
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

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
                                dataAYC.Add(cobroInfo);
                            }
                        }
                        int totalayc = dataAYC.ToList().Sum(x => x.UdsPagadas);
                        data = totalayc;

                    }

                }

                return data;
            }
            catch (Exception ex)
            {
                return data;
            }
        }

        public async Task<inicioAYCModel> getInicioAYCHDB(int ids, DateTime fechaini, DateTime fechafin)
        {
            inicioAYCModel data = new inicioAYCModel();
            try
            {
                List<CobroAYC> dataAYC = new List<CobroAYC>();
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

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
                                dataAYC.Add(cobroInfo);
                            }
                        }
                        int totalayc = dataAYC.ToList().Sum(x => x.UdsPagadas);
                        int iniciohdb = dataAYC.Where(x => x.Tipo == "HOT-DOG" || x.Tipo == "BURGER").ToList().Sum(x => x.UdsPagadas);
                        double porcentaje = totalayc>0 ? ((double)iniciohdb / (double)totalayc) * (double)100 : 0;
                        data.totalayc = totalayc;
                        data.inicioHDB = iniciohdb;
                        data.porcentaje = porcentaje; 

                    }

                }

                return data;
            }
            catch (Exception ex)
            {
                return data;
            }
        }

        public async Task<PdiferenciasModel> getPDiferencias(int ids, DateTime fechaini, DateTime fechafin)
        {
            PdiferenciasModel data = new PdiferenciasModel();
            try
            {
                // obtener diferencias 
                var diferencias = await _fx.GetDiferencias(ids, fechaini.ToString("yyyy-MM-dd"), fechafin.ToString("yyyy-MM-dd")); 
                var diferenciasAla = diferencias.Where(x=>x.codart == 158).ToList();
                var diferenciasBoneless = diferencias.Where(x => x.codart == 10183).ToList();
                var diferenciasPapas = diferencias.Where(x => x.codart == 10193).ToList();

                // compras del articulo en el periodo 
                double comprasAla = getComprasArticulo(ids,158,fechaini,fechafin);
                double comprasBoneless = getComprasArticulo(ids, 10183, fechaini, fechafin);
                double comprasPapa = getComprasArticulo(ids, 10193, fechaini, fechafin);

                // suma de diferencias por articulo para llenar modelo 
                data.diferenciasAla = diferenciasAla.Sum(x => double.Parse(x.Diferencia));
                data.diferenciasBoneless = diferenciasBoneless.Sum(x => double.Parse(x.Diferencia));
                data.diferenciasPapa = diferenciasPapas.Sum(x => double.Parse(x.Diferencia));

                // llenar modelo con las compras
                data.comprasAla = comprasAla;
                data.comprasBoneless = comprasBoneless;
                data.comprasPapa = comprasPapa;

                // obtener porcentajes
                data.pdifAla = comprasAla>0 ? (data.diferenciasAla / comprasAla) * (double)100 :0;
                data.pdifBoneless = comprasBoneless>0 ? (data.diferenciasBoneless / comprasBoneless) * (double)100 : 0;
                data.pdifPapas = comprasPapa>0 ? (data.diferenciasPapa / comprasPapa) * (double)100 :0;

                return data;
            }
            catch (Exception ex)
            {
                return data;
            }
        }

        public async Task<PmermasModel> getMermas(int ids, DateTime fechaini, DateTime fechafin, PdiferenciasModel datadif)
        {
            PmermasModel data = new PmermasModel();
            try
            {
                var sucursal = _db2Context.RemFronts.Where(x => x.Idfront == ids).FirstOrDefault(); 
          
                double mermasala = (double)_dbRebelContext.ItMermas.Where(x => x.Codarticulo == 158 && x.Fecha.Value.Date >= fechaini.Date && x.Fecha <= fechafin.Date && x.Justificacion == "MERMA OPERATIVA" && x.Sucursal == sucursal.Titulo).Sum(x => x.Unidades);
                double mermasBoneless = (double)_dbRebelContext.ItMermas.Where(x => x.Codarticulo == 10183 && x.Fecha.Value.Date >= fechaini.Date && x.Fecha <= fechafin.Date && x.Justificacion == "MERMA OPERATIVA" && x.Sucursal == sucursal.Titulo).Sum(x => x.Unidades);
                double mermaspapa = (double)_dbRebelContext.ItMermas.Where(x => x.Codarticulo == 10193 && x.Fecha.Value.Date >= fechaini.Date && x.Fecha <= fechafin.Date && x.Justificacion == "MERMA OPERATIVA" && x.Sucursal == sucursal.Titulo).Sum(x => x.Unidades);

                data.mermasAla = mermasala;
                data.mermasBoneless = mermasBoneless;
                data.mermasPapa = mermaspapa;

                data.pmermasAla = datadif.comprasAla>0 ? (mermasala / datadif.comprasAla) * (double)100: 0; 
                data.pmermasBoneless = datadif.comprasBoneless>0 ? (mermasBoneless / datadif.comprasBoneless) * (double)100 :0;
                data.pmermasPapas = datadif.comprasPapa>0 ? (mermaspapa / datadif.comprasPapa) * (double)100 :0;

                return data;
            }
            catch (Exception ex)
            {
                return data;
            }
        }


        public async Task<PmermasModel> getMermasOperativasRegional(int ids, DateTime fechaini, DateTime fechafin)
        {
            PmermasModel data = new PmermasModel();
            try
            {
                var sucursal = _db2Context.RemFronts.Where(x => x.Idfront == ids).FirstOrDefault();

                double mermasala = (double)_dbRebelContext.ItMermas.Where(x => x.Codarticulo == 158 && x.Fecha.Value.Date >= fechaini.Date && x.Fecha <= fechafin.Date && x.Justificacion == "MERMA OPERATIVA" && x.Sucursal == sucursal.Titulo).Sum(x => x.Unidades);
                double mermasBoneless = (double)_dbRebelContext.ItMermas.Where(x => x.Codarticulo == 10183 && x.Fecha.Value.Date >= fechaini.Date && x.Fecha <= fechafin.Date && x.Justificacion == "MERMA OPERATIVA" && x.Sucursal == sucursal.Titulo).Sum(x => x.Unidades);
                double mermaspapa = (double)_dbRebelContext.ItMermas.Where(x => x.Codarticulo == 10193 && x.Fecha.Value.Date >= fechaini.Date && x.Fecha <= fechafin.Date && x.Justificacion == "MERMA OPERATIVA" && x.Sucursal == sucursal.Titulo).Sum(x => x.Unidades);

                // compras del articulo en el periodo 
                double comprasAla = getComprasArticulo(ids, 158, fechaini, fechafin);
                double comprasBoneless = getComprasArticulo(ids, 10183, fechaini, fechafin);
                double comprasPapa = getComprasArticulo(ids, 10193, fechaini, fechafin);

                data.mermasAla = mermasala;
                data.mermasBoneless = mermasBoneless;
                data.mermasPapa = mermaspapa;

                data.pmermasAla = comprasAla > 0 ? (mermasala / comprasAla) * (double)100 : 0;
                data.pmermasBoneless = comprasBoneless > 0 ? (mermasBoneless / comprasBoneless) * (double)100 : 0;
                data.pmermasPapas = comprasPapa > 0 ? (mermaspapa / comprasPapa) * (double)100 : 0;

                return data;
            }
            catch (Exception ex)
            {
                return data;
            }
        }


        public async Task<double> getPorcentajeTareas(int ids, DateTime fechaini, DateTime fechafin)
        {
            double porcentaje = 0; 
            using HttpClient client = new HttpClient();
            try
            {
                string url = "https://opera.no-ip.net/back/api_rebel_wings/api/Dashboard/" + ids+"/Supervisor?timeOne="+fechaini.ToString("yyyy-MM-dd") + "&timeTwo="+fechafin.ToString("yyyy-MM-dd") + "&isDone=2&city=1";
                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode(); // Lanza una excepción si hay un error HTTP

                string responseBody = await response.Content.ReadAsStringAsync();

                // Usar JsonDocument para parsear el JSON dinámico
                using JsonDocument doc = JsonDocument.Parse(responseBody);
                JsonElement root = doc.RootElement;

                // Acceder a las propiedades del JSON
                JsonElement dash = root.GetProperty("result"); // Asegúrate de que "result" sea el nombre correcto en tu JSON

                // Acceder a las propiedades dentro de "result"
                int omissionsActivities = dash.GetProperty("omissionsActivities").GetInt32();
                int tasksMorningsCount = dash.GetProperty("tasksMorningsCollection").GetArrayLength();
                int tasksEveningsCount = dash.GetProperty("tasksEveningsCollection").GetArrayLength();

                int totalTareas = tasksMorningsCount + tasksEveningsCount;

                if (totalTareas > 0)
                {
                    porcentaje = ((double)omissionsActivities * 100) / totalTareas;
                }

                return porcentaje;
            }
            catch (Exception ex)
            {
                return porcentaje;
            }
        }

        public double getComprasArticulo(int ids, int codart, DateTime fechaini, DateTime fechafin) 
        {
            double compras = 0;

            var cajafront = from rf in _db2Context.RemFronts
                            join rcf in _db2Context.RemCajasfronts on rf.Idfront equals rcf.Idfront
                            where rf.Idfront == ids
                            select new
                            {
                                rf.Titulo,
                                rcf.Codalmventas
                            };
            string codalmacen = cajafront.FirstOrDefault().Codalmventas;


            var resultca = from al in _db2Context.Albcompralins
                           join art in _db2Context.Articulos1 on al.Codarticulo equals art.Codarticulo
                           join cab in _db2Context.Albcompracabs on new { al.Numserie, al.Numalbaran, al.N } equals new { cab.Numserie, cab.Numalbaran, cab.N }
                           where cab.Fechaalbaran.Value.Date >= fechaini.Date &&
                                 cab.Fechaalbaran.Value.Date <= fechafin.Date &&
                                 al.Codarticulo == codart &&
                                 al.Codalmacen == codalmacen
                           group al by al.Codalmacen into grouped
                           select new
                           {
                               CODALMACEN = grouped.Key,
                               COMPRAS = grouped.Sum(x => x.Unidadestotal)
                           };
            var resultlistca = resultca.ToList();

            if (resultlistca.Count > 0) { compras = (double)resultlistca[0].COMPRAS; } else { compras = 0; }
            return compras;
        }

        public double getComprasArticuloAlm(string codalmacen, int codart, DateTime fechaini, DateTime fechafin)
        {
            double compras = 0;

            var resultca = from al in _db2Context.Albcompralins
                           join art in _db2Context.Articulos1 on al.Codarticulo equals art.Codarticulo
                           join cab in _db2Context.Albcompracabs on new { al.Numserie, al.Numalbaran, al.N } equals new { cab.Numserie, cab.Numalbaran, cab.N }
                           where cab.Fechaalbaran.Value.Date >= fechaini.Date &&
                                 cab.Fechaalbaran.Value.Date <= fechafin.Date &&
                                 al.Codarticulo == codart &&
                                 al.Codalmacen == codalmacen
                           group al by al.Codalmacen into grouped
                           select new
                           {
                               CODALMACEN = grouped.Key,
                               COMPRAS = grouped.Sum(x => x.Unidadestotal)
                           };
            var resultlistca = resultca.ToList();

            if (resultlistca.Count > 0) { compras = (double)resultlistca[0].COMPRAS; } else { compras = 0; }
            return compras;
        }

        public System.Drawing.Color getBgColorDM(double porcentaje)
          {
            System.Drawing.Color color = System.Drawing.Color.White;

            if(porcentaje<2.5 && porcentaje>-2.5)
              {
                color = System.Drawing.Color.Green;
              }

            if(porcentaje>=2.5 || porcentaje<=-2.5)
              {
                color = System.Drawing.Color.Red;
              }
            return color; 
          }

        public System.Drawing.Color getBgColorAlcance(double porcentaje)
        {
            System.Drawing.Color color = System.Drawing.Color.White;

            if (porcentaje >=100)
            {
                color = System.Drawing.Color.Green;
            }

            if (porcentaje >=75 && porcentaje < 100)
            {
                color = System.Drawing.Color.Yellow;
            }

            if (porcentaje < 75)
            {
                color = System.Drawing.Color.Red;
            }

            return color;
        }

        public System.Drawing.Color getBgColorApps(double porcentaje)
        {
            System.Drawing.Color color = System.Drawing.Color.White;

            if (porcentaje >= 100)
            {
                color = System.Drawing.Color.DarkGreen;
            }

            if (porcentaje >= 90 && porcentaje < 100)
            {
                color = System.Drawing.Color.Green;
            }

            if (porcentaje >= 80 && porcentaje < 90)
            {
                color = System.Drawing.Color.Yellow;
            }

            if (porcentaje < 80)
            {
                color = System.Drawing.Color.Red;
            }

            return color;
        }

        public Boolean esAmarillo(System.Drawing.Color color) 
        {
            Boolean status = false;
            if (color == System.Drawing.Color.Yellow)
            {
                status = true;
            }         
            return status;
        }

        public async Task<List<int>> getSucursales() 
        {
            List<int> sucursales = new List<int>();
            string query = @"
       SELECT RF.IDFRONT AS cod, RF.TITULO AS name
FROM ALMACEN ALM WITH(NOLOCK)
INNER JOIN REM_CAJASFRONT RCF WITH(NOLOCK) ON ALM.CODALMACEN COLLATE Latin1_General_CS_AI = RCF.CODALMVENTAS
INNER JOIN SERIESCAMPOSLIBRES SCL WITH(NOLOCK) ON RCF.SERIETIQUETS COLLATE Latin1_General_CS_AI = SCL.SERIE
INNER JOIN REM_FRONTS RF ON RF.IDFRONT = RCF.IDFRONT 
WHERE (ALM.NOTAS LIKE N'RW') AND (RCF.CAJAFRONT = 1)";

            using (SqlConnection connection = new SqlConnection(connectionStringBd2))
            {
                SqlCommand command = new SqlCommand(query, connection);

                // Abrir la conexión
                connection.Open();

                // Ejecutar el comando y obtener los datos
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    // Crear una tabla para almacenar los datos
                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);

                    // Imprimir los datos (para prueba)
                    foreach (DataRow row in dataTable.Rows)
                    {
                        sucursales.Add(int.Parse(row[0].ToString()));
                    }
                }

            }
            return sucursales;
        }

    }

    public class costoModel
    {
        public int ids { get; set; }
        public double compras { get; set; }
        public double costo { get; set; }
    }

    public class PorcentajeBebidaModel
    {
        public double ventaAlimentosSalon { get; set; }
        public double ventaBebidasSalon { get; set; }   
        public double porcentaje { get; set; }  
        public int totalAYC { get; set; }   
    }

    public class inicioAYCModel 
    {
        public int totalayc { get; set; }
        public int inicioHDB { get; set;}
        public double porcentaje { get; set; }
    }

    public class PdiferenciasModel 
    {
        public double diferenciasAla {  get; set; }
        public double comprasAla { get; set; }
        public double diferenciasBoneless { get; set; }
        public double comprasBoneless { get;set; }
        public double diferenciasPapa { get; set; }
        public double comprasPapa { get;set; }
        public double pdifAla { get; set; } 
        public double pdifBoneless { get; set; }
        public double pdifPapas { get; set; }   
    }

    public class PmermasModel
    {
        public double mermasAla { get; set; }
        public double mermasBoneless { get; set; }
        public double mermasPapa { get; set; }
        public double pmermasAla { get; set; }
        public double pmermasBoneless { get; set; }
        public double pmermasPapas { get; set; }
    }

}
