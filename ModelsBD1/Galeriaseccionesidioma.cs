using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Galeriaseccionesidioma
    {
        public int Idgaleria { get; set; }
        public int Numseccion { get; set; }
        public string Codidioma { get; set; } = null!;
        public string? Descripcion { get; set; }

        public virtual Galeriaseccione Galeriaseccione { get; set; } = null!;
    }
}
