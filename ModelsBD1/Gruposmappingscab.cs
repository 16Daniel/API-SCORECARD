using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Gruposmappingscab
    {
        public Gruposmappingscab()
        {
            Gruposmappingslins = new HashSet<Gruposmappingslin>();
        }

        public int Idgrupo { get; set; }
        public string? Descripcion { get; set; }

        public virtual ICollection<Gruposmappingslin> Gruposmappingslins { get; set; }
    }
}
