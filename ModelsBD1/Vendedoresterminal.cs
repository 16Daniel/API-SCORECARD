using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Vendedoresterminal
    {
        public int Codvendedor { get; set; }
        public string Terminal { get; set; } = null!;

        public virtual Vendedore CodvendedorNavigation { get; set; } = null!;
    }
}
