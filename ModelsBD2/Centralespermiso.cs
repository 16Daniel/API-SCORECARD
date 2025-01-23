using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Centralespermiso
    {
        public Centralespermiso()
        {
            Centralesvalores = new HashSet<Centralesvalore>();
        }

        public int Idcentral { get; set; }
        public int Idpermiso { get; set; }
        public string? Seleccionado { get; set; }
        public int? Tipo { get; set; }

        public virtual Centrale IdcentralNavigation { get; set; } = null!;
        public virtual ICollection<Centralesvalore> Centralesvalores { get; set; }
    }
}
