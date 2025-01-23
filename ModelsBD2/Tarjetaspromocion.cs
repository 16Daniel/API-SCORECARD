using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Tarjetaspromocion
    {
        public int Idpromocion { get; set; }
        public int Idtipotarjeta { get; set; }

        public virtual Promocione IdpromocionNavigation { get; set; } = null!;
    }
}
