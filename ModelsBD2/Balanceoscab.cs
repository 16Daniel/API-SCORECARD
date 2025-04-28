using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Balanceoscab
    {
        public Balanceoscab()
        {
            Balanceoslins = new HashSet<Balanceoslin>();
        }

        public int Codigo { get; set; }
        public string? Nombre { get; set; }
        public DateTime? Fecha { get; set; }

        public virtual ICollection<Balanceoslin> Balanceoslins { get; set; }
    }
}
