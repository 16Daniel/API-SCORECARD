using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Cargodtohoteltarifa
    {
        public int Codarticulo { get; set; }
        public int Codtarifa { get; set; }

        public virtual Tarifashotel CodtarifaNavigation { get; set; } = null!;
    }
}
