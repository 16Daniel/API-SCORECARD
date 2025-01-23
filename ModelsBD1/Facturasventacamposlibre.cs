using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Facturasventacamposlibre
    {
        public string Numserie { get; set; } = null!;
        public int Numfactura { get; set; }
        public string N { get; set; } = null!;
        public string? Requisicion { get; set; }
        public string? Usocfdi { get; set; }
        public string? Metodopago { get; set; }
        public string? Formapago { get; set; }
        public string? Factura { get; set; }
        public string? Tiporelacion { get; set; }

        public virtual Facturasventum NNavigation { get; set; } = null!;
    }
}
