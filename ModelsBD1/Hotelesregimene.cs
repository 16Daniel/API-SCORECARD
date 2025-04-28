using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Hotelesregimene
    {
        public int Idhotel { get; set; }
        public int Codarticulo { get; set; }
        public int Posicion { get; set; }
        public byte[] Version { get; set; } = null!;

        public virtual Articulosregimene CodarticuloNavigation { get; set; } = null!;
        public virtual Hotele IdhotelNavigation { get; set; } = null!;
    }
}
