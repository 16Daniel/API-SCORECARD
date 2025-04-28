using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Ruta
    {
        public Ruta()
        {
            Rutaslins = new HashSet<Rutaslin>();
        }

        public int Codruta { get; set; }
        public string? Descripcion { get; set; }
        public byte[]? Version { get; set; }

        public virtual ICollection<Rutaslin> Rutaslins { get; set; }
    }
}
