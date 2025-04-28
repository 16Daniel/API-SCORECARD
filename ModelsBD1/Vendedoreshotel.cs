using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Vendedoreshotel
    {
        public int Codvendedor { get; set; }
        public int Idhotel { get; set; }

        public virtual Vendedore CodvendedorNavigation { get; set; } = null!;
    }
}
