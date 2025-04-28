using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Motivosabono
    {
        public Motivosabono()
        {
            MotivosabonoIdiomas = new HashSet<MotivosabonoIdioma>();
        }

        public int Id { get; set; }
        public string? Descripcion { get; set; }
        public byte[]? Version { get; set; }

        public virtual ICollection<MotivosabonoIdioma> MotivosabonoIdiomas { get; set; }
    }
}
