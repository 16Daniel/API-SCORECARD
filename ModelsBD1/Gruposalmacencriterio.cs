using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Gruposalmacencriterio
    {
        public Gruposalmacencriterio()
        {
            Gruposalmacenlincriterios = new HashSet<Gruposalmacenlincriterio>();
        }

        public int Idgrupo { get; set; }
        public int Idcriterio { get; set; }
        public string? Titulocolumna { get; set; }

        public virtual ICollection<Gruposalmacenlincriterio> Gruposalmacenlincriterios { get; set; }
    }
}
