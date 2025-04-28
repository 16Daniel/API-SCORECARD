using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Consumoscab
    {
        public string Serie { get; set; } = null!;
        public int Numero { get; set; }
        public DateTime? Fecha { get; set; }
        public string? Codalmacen { get; set; }
        public string? Contabilizado { get; set; }
        public int? EnlaceEmpresa { get; set; }
        public int? EnlaceEjercicio { get; set; }
        public string? EnlaceUsuario { get; set; }
        public int? EnlaceAsiento { get; set; }
        public int? Codvendedor { get; set; }
        public int? Tipovaloracion { get; set; }
    }
}
