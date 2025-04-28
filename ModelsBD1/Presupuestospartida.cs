using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Presupuestospartida
    {
        public string Numserie { get; set; } = null!;
        public int Numpresupuesto { get; set; }
        public string N { get; set; } = null!;
        public int Version { get; set; }
        public int Idpartida { get; set; }
        public string? Area { get; set; }
        public string? Descripcion { get; set; }
        public double? Total { get; set; }

        public virtual Presupuestoscab Presupuestoscab { get; set; } = null!;
    }
}
