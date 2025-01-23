using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Hoteleshabitacionesweb
    {
        public int Idhotel { get; set; }
        public int Codarticulo { get; set; }
        public int Posicion { get; set; }
        public byte[] Version { get; set; } = null!;

        public virtual Articuloshabitacione CodarticuloNavigation { get; set; } = null!;
        public virtual Hotele IdhotelNavigation { get; set; } = null!;
    }
}
