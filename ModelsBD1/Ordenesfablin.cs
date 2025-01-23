using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Ordenesfablin
    {
        public string Serie { get; set; } = null!;
        public int Numero { get; set; }
        public int Codigoart { get; set; }
        public string Talla { get; set; } = null!;
        public string Color { get; set; } = null!;
        public string? Descripcion { get; set; }
        public string? Referencia { get; set; }
        public double? Unidades { get; set; }
        public double? Udscomponente { get; set; }
        public double? Udstotal { get; set; }
        public double? Coste { get; set; }
        public double? Pesototal { get; set; }
        public string? Desglosado { get; set; }
        public double? Udmedida2 { get; set; }
    }
}
