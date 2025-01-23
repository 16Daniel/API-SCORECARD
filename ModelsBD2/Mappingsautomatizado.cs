using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Mappingsautomatizado
    {
        public Mappingsautomatizado()
        {
            Mappingsautomatizadosfiles = new HashSet<Mappingsautomatizadosfile>();
        }

        public int Id { get; set; }
        public DateTime? Fecha { get; set; }
        public DateTime? Hora { get; set; }
        public int? Idmap { get; set; }
        public int? Idgrupo { get; set; }
        public string? Correcto { get; set; }
        public string? Fichlog { get; set; }
        public string? Msgerror { get; set; }
        public int? Coderror { get; set; }

        public virtual ICollection<Mappingsautomatizadosfile> Mappingsautomatizadosfiles { get; set; }
    }
}
