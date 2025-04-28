using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class AnulAlbventacupone
    {
        public string Numserie { get; set; } = null!;
        public int Numalbaran { get; set; }
        public string N { get; set; } = null!;
        public string Eancupon { get; set; } = null!;

        public virtual AnulAlbventacab NNavigation { get; set; } = null!;
    }
}
