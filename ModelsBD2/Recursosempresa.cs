using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Recursosempresa
    {
        public Recursosempresa()
        {
            Codgrupos = new HashSet<Gruporecurso>();
            Servicios = new HashSet<Servicio>();
        }

        public int Codrecurso { get; set; }
        public string Nomrecurso { get; set; } = null!;
        public string? Codalmacen { get; set; }
        public byte[] Version { get; set; } = null!;
        public int Paxmax { get; set; }

        public virtual ICollection<Gruporecurso> Codgrupos { get; set; }
        public virtual ICollection<Servicio> Servicios { get; set; }
    }
}
