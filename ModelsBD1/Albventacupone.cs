using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Albventacupone
    {
        public string Numserie { get; set; } = null!;
        public int Numalbaran { get; set; }
        public string N { get; set; } = null!;
        public string Eancupon { get; set; } = null!;
        public int? Idcupon { get; set; }
        public double? Importedto { get; set; }

        public virtual Albventacab NNavigation { get; set; } = null!;
    }
}
