using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Hcierreproduccion
    {
        public int Idhotel { get; set; }
        public DateTime Fecha { get; set; }
        public int? Codvendedor { get; set; }
        public short? EnlaceEjercicio { get; set; }
        public short? EnlaceEmpresa { get; set; }
        public string? EnlaceUsuario { get; set; }
        public int? EnlaceAsiento { get; set; }
    }
}
