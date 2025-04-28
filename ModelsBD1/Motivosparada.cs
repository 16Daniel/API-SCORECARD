using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Motivosparada
    {
        public Motivosparada()
        {
            Serviciosparada = new HashSet<Serviciosparada>();
        }

        public int Codparada { get; set; }
        public string? Descparada { get; set; }

        public virtual ICollection<Serviciosparada> Serviciosparada { get; set; }
    }
}
