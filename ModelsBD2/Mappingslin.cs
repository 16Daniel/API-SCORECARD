using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Mappingslin
    {
        public int Idmap { get; set; }
        public int Idcampo { get; set; }
        public string? Camposrc { get; set; }
        public string? Campodst { get; set; }
        public int? Lencampo { get; set; }
        public int? Posiciondecimal { get; set; }
        public int? Posorigen { get; set; }

        public virtual Mapping IdmapNavigation { get; set; } = null!;
    }
}
