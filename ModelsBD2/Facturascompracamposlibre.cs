using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Facturascompracamposlibre
    {
        public string Numserie { get; set; } = null!;
        public int Numfactura { get; set; }
        public string N { get; set; } = null!;
        public string? Sucursal { get; set; }

        public virtual Facturascompra NNavigation { get; set; } = null!;
    }
}
