using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Gruposmappingslin
    {
        public int Idgrupo { get; set; }
        public int Numlin { get; set; }
        public int? Idmap { get; set; }
        public int? Prioridad { get; set; }
        public string? Fichero { get; set; }
        public string? Empresacontab { get; set; }
        public int? Idftp { get; set; }
        public int? Idbuzon { get; set; }
        public int? Idbd { get; set; }

        public virtual Gruposmappingscab IdgrupoNavigation { get; set; } = null!;
    }
}
