using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Familia
    {
        public Familia()
        {
            Subfamilia = new HashSet<Subfamilia>();
        }

        public int Numdpto { get; set; }
        public int Numseccion { get; set; }
        public int Numfamilia { get; set; }
        public string? Descripcion { get; set; }
        public string? Codigo { get; set; }
        public byte[]? Imagen { get; set; }
        public byte[] Version { get; set; } = null!;

        public virtual Seccione Num { get; set; } = null!;
        public virtual ICollection<Subfamilia> Subfamilia { get; set; }
    }
}
