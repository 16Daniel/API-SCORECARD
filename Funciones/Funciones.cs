using DashboardApi.Controllers;
using DashboardApi.ModelsBD1;
using DashboardApi.ModelsBD2;
using DashboardApi.ModelsDashboard;
using DashboardApi.ModelsDBRebel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Data;
using System.Globalization;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace DashboardApi.Funciones
{
    public class Funciones
    {
        BD1Context _db1Context;
        BD2Context _db2Context;
        DBRebelContext _dbRebelContext;
        private readonly IConfiguration _configuration;
        public string connectionString = string.Empty;
        public string connectionStringDBREBEL = string.Empty;
        public string connectionStringBd2 = string.Empty;
        DashboardContext _dashboardContext;

        public Funciones(BD1Context d1Context, BD2Context bD2Context, DBRebelContext dBRebelContext, IConfiguration configuration, DashboardContext dashboardcontext)
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

        public async Task<List<Reporte>> GetDiferencias(int ids, string fechaini, string fechafin)
        {

            DateTime fecha = DateTime.ParseExact(fechaini, "yyyy-MM-dd", CultureInfo.InvariantCulture);
            DateTime fecha2 = DateTime.ParseExact(fechafin, "yyyy-MM-dd", CultureInfo.InvariantCulture);

            int diasDiferencia = (fecha2 - fecha).Days;
            diasDiferencia++;
            List<Reporte> reportes = new List<Reporte>();
            SqlConnection connection = (SqlConnection)_dashboardContext.Database.GetDbConnection();
            SqlCommand cmd = connection.CreateCommand();
            connection.Open();

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
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "GET_DIFERENCIAS_TABLA";
            cmd.Parameters.Add("@FECHAINI", SqlDbType.VarChar, 10).Value = fecha.ToString("dd/MM/yyyy");
            cmd.Parameters.Add("@FECHAFIN", SqlDbType.VarChar, 10).Value = fecha2.ToString("dd/MM/yyyy");
            cmd.Parameters.Add("@IDS", SqlDbType.VarChar, 10).Value = codalmacen;
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
            connection.Close();

            return reportes;
        }
        public async Task<int> getTotalAYC(int ids, string fechaini, string fechafin)
        {
            int total = 0;

            DateTime fecha = DateTime.ParseExact(fechaini, "yyyy-MM-dd", CultureInfo.InvariantCulture);
            DateTime fecha2 = DateTime.ParseExact(fechafin, "yyyy-MM-dd", CultureInfo.InvariantCulture);


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("[dbo].[GET_TOTAL_AYC]", connection))
                {

                    command.CommandType = CommandType.StoredProcedure;

                    // Añadir los parámetros al comando
                    command.Parameters.Add(new SqlParameter("@FECHAINI", fecha));
                    command.Parameters.Add(new SqlParameter("@FECHAFIN", fecha2));
                    command.Parameters.Add(new SqlParameter("@IDS", ids));

                    // Abrir la conexión


                    // Ejecutar el comando y leer los resultados
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            total = reader["TOTAL"] != DBNull.Value ? Convert.ToInt32(reader["TOTAL"]) : 0;
                        }
                    }


                }
            }


            return total;

        }


        public async Task<int> getTotalAYC_V(int ids, string fechaini, string fechafin, int codvendedor)
        {
            int total = 0;

            DateTime fecha = DateTime.ParseExact(fechaini, "yyyy-MM-dd", CultureInfo.InvariantCulture);
            DateTime fecha2 = DateTime.ParseExact(fechafin, "yyyy-MM-dd", CultureInfo.InvariantCulture);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("[dbo].[GET_TOTAL_AYC_VENDEDOR]", connection))
                {

                    command.CommandType = CommandType.StoredProcedure;

                    // Añadir los parámetros al comando
                    command.Parameters.Add(new SqlParameter("@FECHAINI", fecha));
                    command.Parameters.Add(new SqlParameter("@FECHAFIN", fecha2));
                    command.Parameters.Add(new SqlParameter("@IDS", ids));
                    command.Parameters.Add(new SqlParameter("@CODVENDEDOR", codvendedor));

                    // Abrir la conexión


                    // Ejecutar el comando y leer los resultados
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            total = Convert.ToInt32(reader["TOTAL"]);
                        }
                    }


                }
            }


            return total;

        }


    }
}
