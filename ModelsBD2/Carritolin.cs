using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Carritolin
    {
        public string Idcarrito { get; set; } = null!;
        public int Idlinea { get; set; }
        public int? Codarticulo { get; set; }
        public string? Talla { get; set; }
        public string? Color { get; set; }
        public double? Unidades1 { get; set; }
        public double? Unidades2 { get; set; }
        public int? Idtarifav { get; set; }
        public double? Precio { get; set; }
        public double? Descuento { get; set; }
        public int? Tipoimpuesto { get; set; }
        public double? Iva { get; set; }
        public double? Req { get; set; }
        public double? Udsregalo1 { get; set; }
        public double? Udsregalo2 { get; set; }
        public double? X { get; set; }
        public double? Y { get; set; }
        public double? Total { get; set; }
        public int? Tipo { get; set; }

        public virtual Carritocab IdcarritoNavigation { get; set; } = null!;
    }
}
