using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Subfamilia
    {
        public int Numdpto { get; set; }
        public int Numseccion { get; set; }
        public int Numfamilia { get; set; }
        public int Numsubfamilia { get; set; }
        public string? Descripcion { get; set; }
        public string? Codigo { get; set; }

        public virtual Familia Num { get; set; } = null!;
    }
}
