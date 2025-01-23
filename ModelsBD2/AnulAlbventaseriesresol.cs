using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class AnulAlbventaseriesresol
    {
        public string Numserie { get; set; } = null!;
        public int Numalbaran { get; set; }
        public string N { get; set; } = null!;
        public string Seriefiscal1 { get; set; } = null!;
        public string Seriefiscal2 { get; set; } = null!;
        public int Numerofiscal { get; set; }

        public virtual AnulAlbventacab NNavigation { get; set; } = null!;
    }
}
