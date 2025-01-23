using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Pedventalinpromocione
    {
        public string Numserie { get; set; } = null!;
        public int Numpedido { get; set; }
        public string N { get; set; } = null!;
        public int Numlin { get; set; }
        public int Idpromocion { get; set; }
        public double? Importepromocion { get; set; }
        public double? Importepromocioniva { get; set; }

        public virtual Pedventalin NNavigation { get; set; } = null!;
    }
}
