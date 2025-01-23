using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Promocionesgrupo
    {
        public int Idpromocion { get; set; }
        public int Posicion { get; set; }
        public int? Idgrupo { get; set; }

        public virtual Promocione IdpromocionNavigation { get; set; } = null!;
    }
}
