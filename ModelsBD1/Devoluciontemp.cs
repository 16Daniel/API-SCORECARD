using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Devoluciontemp
    {
        public int Codproveedor { get; set; }
        public int Numterminal { get; set; }
        public int Numlinea { get; set; }
        public DateTime? Fecha { get; set; }
        public int? Idmotivocab { get; set; }
        public int? Codarticulo { get; set; }
        public string? Talla { get; set; }
        public string? Color { get; set; }
        public double? Uds { get; set; }
        public string? Observaciones { get; set; }
        public int? Idmotivo { get; set; }
    }
}
