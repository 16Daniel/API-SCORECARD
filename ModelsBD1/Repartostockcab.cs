using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Repartostockcab
    {
        public Repartostockcab()
        {
            Repartostocks = new HashSet<Repartostock>();
        }

        public int Codigo { get; set; }
        public string? Nombre { get; set; }
        public DateTime? Fecha { get; set; }
        public string? Almorig { get; set; }

        public virtual ICollection<Repartostock> Repartostocks { get; set; }
    }
}
