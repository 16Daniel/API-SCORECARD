using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Nomina
    {
        public int Codempleado { get; set; }
        public int Mes { get; set; }
        public int Anyo { get; set; }
        public double? TotalDevengado { get; set; }
        public double? Retirpf { get; set; }
        public double? Ssempleado { get; set; }
        public double? Ssempresa { get; set; }
        public bool? Contabilizado { get; set; }
        public int? EnlaceEmpresa { get; set; }
        public int? EnlaceEjercicio { get; set; }
        public int? EnlaceAsiento { get; set; }
        public string? EnlaceUsuario { get; set; }

        public virtual Vendedore CodempleadoNavigation { get; set; } = null!;
    }
}
