using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Chequeotemp
    {
        public string Tipodoc { get; set; } = null!;
        public string Serie { get; set; } = null!;
        public int Numero { get; set; }
        public int Numlinea { get; set; }
        public string Caja { get; set; } = null!;
        public int? Codarticulo { get; set; }
        public string? Talla { get; set; }
        public string? Color { get; set; }
        public double? Uds1 { get; set; }
        public double? Uds2 { get; set; }
        public double? Uds3 { get; set; }
        public double? Uds4 { get; set; }
        public string? DocfinSerie { get; set; }
        public int? DocfinNumero { get; set; }
        public string? Codbarras { get; set; }
    }
}
