using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Albventacuponesgenerado
    {
        public string Numserie { get; set; } = null!;
        public int Numalbaran { get; set; }
        public string N { get; set; } = null!;
        public int Idpromocion { get; set; }
        public string Eancupon { get; set; } = null!;
        public double? Unidades { get; set; }
        public double? Importedto { get; set; }
        public int? PromocionesclienteIdpromocion { get; set; }

        public virtual Albventacab NNavigation { get; set; } = null!;
    }
}
