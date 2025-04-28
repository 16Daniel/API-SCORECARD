using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Presupuestoscamposlibre
    {
        public string Numserie { get; set; } = null!;
        public int Numpresupuesto { get; set; }
        public string N { get; set; } = null!;
        public int Version { get; set; }

        public virtual Presupuestoscab Presupuestoscab { get; set; } = null!;
    }
}
