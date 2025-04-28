using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Reparto
    {
        public int Id { get; set; }
        public int? Dpto { get; set; }
        public int? Seccion { get; set; }
        public int? Familia { get; set; }
        public int? Subfamilia { get; set; }
        public string? Codalmacen { get; set; }
        public double? Valor { get; set; }
        public int? Nivel { get; set; }
    }
}
