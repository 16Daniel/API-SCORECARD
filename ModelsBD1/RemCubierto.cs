using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class RemCubierto
    {
        public int Idfront { get; set; }
        public short Sala { get; set; }
        public short Mesa { get; set; }
        public short Numlinea { get; set; }
        public int Codarticulo { get; set; }
        public double? Unidades { get; set; }
        public string? Porcomensal { get; set; }

        public virtual RemFront IdfrontNavigation { get; set; } = null!;
    }
}
