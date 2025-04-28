using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Presupuesto
    {
        public string Numserie { get; set; } = null!;
        public int Numpresupuesto { get; set; }
        public string N { get; set; } = null!;
        public string? Supresupuesto { get; set; }
    }
}
