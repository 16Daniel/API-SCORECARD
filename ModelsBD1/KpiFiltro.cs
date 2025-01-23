using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class KpiFiltro
    {
        public KpiFiltro()
        {
            KpiFiltroDefs = new HashSet<KpiFiltroDef>();
        }

        public int Idfiltro { get; set; }
        public string? Tablafiltro { get; set; }
        public string? Camposid { get; set; }
        public string? Campodesc { get; set; }

        public virtual ICollection<KpiFiltroDef> KpiFiltroDefs { get; set; }
    }
}
