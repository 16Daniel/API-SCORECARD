using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Galeriaseccione
    {
        public Galeriaseccione()
        {
            Galeriaarticulos = new HashSet<Galeriaarticulo>();
            Galeriaseccionesidiomas = new HashSet<Galeriaseccionesidioma>();
        }

        public int Idgaleria { get; set; }
        public int Numseccion { get; set; }
        public int? Colorfondo { get; set; }
        public int? Colortexto { get; set; }
        public byte[]? Foto { get; set; }

        public virtual Galerium IdgaleriaNavigation { get; set; } = null!;
        public virtual ICollection<Galeriaarticulo> Galeriaarticulos { get; set; }
        public virtual ICollection<Galeriaseccionesidioma> Galeriaseccionesidiomas { get; set; }
    }
}
