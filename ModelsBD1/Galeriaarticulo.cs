using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Galeriaarticulo
    {
        public Galeriaarticulo()
        {
            Galeriaarticulosidiomas = new HashSet<Galeriaarticulosidioma>();
        }

        public int Idgaleria { get; set; }
        public int Codarticulo { get; set; }
        public byte[]? Imagen { get; set; }
        public int? Numdpto { get; set; }
        public int Numseccion { get; set; }

        public virtual Galeriaseccione Galeriaseccione { get; set; } = null!;
        public virtual ICollection<Galeriaarticulosidioma> Galeriaarticulosidiomas { get; set; }
    }
}
