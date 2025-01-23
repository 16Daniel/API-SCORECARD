using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Festivoshotel
    {
        public int Idhotel { get; set; }
        public int Year { get; set; }
        public string? Festivos { get; set; }
        public int Color1 { get; set; }
        public int Color2 { get; set; }

        public virtual Hotele IdhotelNavigation { get; set; } = null!;
    }
}
