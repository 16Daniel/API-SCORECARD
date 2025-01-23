using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class AnulAlbventalinpromocione
    {
        public string Numserie { get; set; } = null!;
        public int Numalbaran { get; set; }
        public string N { get; set; } = null!;
        public int Numlin { get; set; }
        public int Idpromocion { get; set; }
        public double? Importepromocion { get; set; }
        public double? Importepromocioniva { get; set; }

        public virtual AnulAlbventalin NNavigation { get; set; } = null!;
    }
}
