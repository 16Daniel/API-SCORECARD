using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Previsioncompra
    {
        public int Id { get; set; }
        public int Anyo { get; set; }
        public string Filtro { get; set; } = null!;
        public double? Prevision { get; set; }
        public double? Enero { get; set; }
        public double? Febrero { get; set; }
        public double? Marzo { get; set; }
        public double? Abril { get; set; }
        public double? Mayo { get; set; }
        public double? Junio { get; set; }
        public double? Julio { get; set; }
        public double? Agosto { get; set; }
        public double? Septiembre { get; set; }
        public double? Octubre { get; set; }
        public double? Noviembre { get; set; }
        public double? Diciembre { get; set; }
    }
}
