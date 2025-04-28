using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Actividade
    {
        public Actividade()
        {
            Clientesactividads = new HashSet<Clientesactividad>();
        }

        public int Codactividad { get; set; }
        public string? Descripcion { get; set; }

        public virtual ICollection<Clientesactividad> Clientesactividads { get; set; }
    }
}
