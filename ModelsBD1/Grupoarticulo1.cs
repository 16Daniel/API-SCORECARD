using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Grupoarticulo1
    {
        public Grupoarticulo1()
        {
            Elementosgrupos = new HashSet<Elementosgrupo>();
        }

        public int Idgrupo { get; set; }
        public string? Descripcion { get; set; }

        public virtual ICollection<Elementosgrupo> Elementosgrupos { get; set; }
    }
}
