using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Facturascompracuenta
    {
        public string Numserie { get; set; } = null!;
        public int Numfactura { get; set; }
        public string N { get; set; } = null!;
        public int Numlinea { get; set; }
        public int? Tipo { get; set; }
        public string? Cuenta { get; set; }
        public double? Importe { get; set; }
        public string? Centrocoste { get; set; }

        public virtual Facturascompra NNavigation { get; set; } = null!;
    }
}
