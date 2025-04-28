using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Facturascompracomprobanteret
    {
        public string Numserie { get; set; } = null!;
        public int Numfactura { get; set; }
        public string N { get; set; } = null!;
        public string Serie { get; set; } = null!;
        public int Numero { get; set; }
        public bool Manual { get; set; }
        public bool Electronica { get; set; }

        public virtual Facturascompra NNavigation { get; set; } = null!;
    }
}
