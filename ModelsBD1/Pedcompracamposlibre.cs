using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Pedcompracamposlibre
    {
        public string Numserie { get; set; } = null!;
        public int Numpedido { get; set; }
        public string N { get; set; } = null!;
        public string? Sucursal { get; set; }

        public virtual Pedcompracab NNavigation { get; set; } = null!;
    }
}
