using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class EstadisticaGrupo
    {
        public EstadisticaGrupo()
        {
            EstadisticaSubgrupos = new HashSet<EstadisticaSubgrupo>();
            Estadisticas = new HashSet<Estadistica>();
        }

        public int Idgrupo { get; set; }
        public string? Descripcion { get; set; }

        public virtual ICollection<EstadisticaSubgrupo> EstadisticaSubgrupos { get; set; }
        public virtual ICollection<Estadistica> Estadisticas { get; set; }
    }
}
