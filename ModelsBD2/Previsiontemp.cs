using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Previsiontemp
    {
        public string Codalmacen { get; set; } = null!;
        public int Numlinea { get; set; }
        public int? Codarticulo { get; set; }
        public string? Talla { get; set; }
        public string? Color { get; set; }
        public double? Uds { get; set; }
        public int? Idtarifac { get; set; }
        public int? Codproveedor { get; set; }
        public double? Pbruto { get; set; }
        public string? Dtotexto { get; set; }
        public double? Pneto { get; set; }
        public double? X { get; set; }
        public double? Y { get; set; }
        public int? Codmoneda { get; set; }
        public string? Supedido { get; set; }
        public int? Codcliente { get; set; }
        public int Numterminal { get; set; }
        public double? Udsnecesarias { get; set; }
    }
}
