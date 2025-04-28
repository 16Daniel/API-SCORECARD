using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Hestadoshabitacione
    {
        public Hestadoshabitacione()
        {
            Hcuposestadosdefectos = new HashSet<Hcuposestadosdefecto>();
            Hestadosdefectos = new HashSet<Hestadosdefecto>();
        }

        public string Id { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public int? Colorfondo { get; set; }
        public int? Colortexto { get; set; }
        public bool? Checkin { get; set; }
        public bool? Decamarera { get; set; }
        public byte[]? Version { get; set; }

        public virtual ICollection<Hcuposestadosdefecto> Hcuposestadosdefectos { get; set; }
        public virtual ICollection<Hestadosdefecto> Hestadosdefectos { get; set; }
    }
}
