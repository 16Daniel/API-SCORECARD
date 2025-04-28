using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Pedventacuponesgenerado
    {
        public string Numserie { get; set; } = null!;
        public int Numpedido { get; set; }
        public string N { get; set; } = null!;
        public int Idpromocion { get; set; }
        public string Eancupon { get; set; } = null!;
        public double? Unidades { get; set; }
        public double? Importedto { get; set; }
        public int? PromocionesclienteIdpromocion { get; set; }

        public virtual Pedventacab NNavigation { get; set; } = null!;
    }
}
