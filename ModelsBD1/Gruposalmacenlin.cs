using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Gruposalmacenlin
    {
        public Gruposalmacenlin()
        {
            Gruposalmacenlincriterios = new HashSet<Gruposalmacenlincriterio>();
        }

        public int Idgrupo { get; set; }
        public string Codalmacen { get; set; } = null!;
        public int? Posicion { get; set; }

        public virtual Almacen CodalmacenNavigation { get; set; } = null!;
        public virtual Gruposalmacencab IdgrupoNavigation { get; set; } = null!;
        public virtual ICollection<Gruposalmacenlincriterio> Gruposalmacenlincriterios { get; set; }
    }
}
