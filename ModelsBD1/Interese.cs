using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Interese
    {
        public Interese()
        {
            Clientesinteres = new HashSet<Clientesintere>();
        }

        public int Codinteres { get; set; }
        public string? Descripcion { get; set; }

        public virtual ICollection<Clientesintere> Clientesinteres { get; set; }
    }
}
