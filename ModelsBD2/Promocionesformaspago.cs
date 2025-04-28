using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Promocionesformaspago
    {
        public int Idpromocion { get; set; }
        public string Codformapago { get; set; } = null!;

        public virtual Promocione IdpromocionNavigation { get; set; } = null!;
    }
}
