using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Pedventacamposlibre
    {
        public string Numserie { get; set; } = null!;
        public int Numpedido { get; set; }
        public string N { get; set; } = null!;
        public string? Requisicion { get; set; }

        public virtual Pedventacab NNavigation { get; set; } = null!;
    }
}
