using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Pedventacupone
    {
        public string Numserie { get; set; } = null!;
        public int Numpedido { get; set; }
        public string N { get; set; } = null!;
        public string Eancupon { get; set; } = null!;
        public int? Idcupon { get; set; }
        public double? Importedto { get; set; }

        public virtual Pedventacab NNavigation { get; set; } = null!;
    }
}
