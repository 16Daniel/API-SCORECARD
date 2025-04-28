using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Hcuposextra
    {
        public int Idhotel { get; set; }
        public int Idcupo { get; set; }
        public int Codarticulo { get; set; }
        public int Posicion { get; set; }
        public byte[]? Version { get; set; }

        public virtual Articulo1 CodarticuloNavigation { get; set; } = null!;
        public virtual Hcupo IdcupoNavigation { get; set; } = null!;
        public virtual Hotele IdhotelNavigation { get; set; } = null!;
    }
}
