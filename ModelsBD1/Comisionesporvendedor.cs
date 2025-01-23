using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Comisionesporvendedor
    {
        public int Tipousuario { get; set; }
        public int Codcomision { get; set; }
        public int Linea { get; set; }
        public string? Areaneg { get; set; }
        public int? Filtroventas { get; set; }
        public int? Modo { get; set; }
        public int? Tipocliente { get; set; }
        public DateTime? Desde { get; set; }
        public DateTime? Hasta { get; set; }

        public virtual Comisionescab CodcomisionNavigation { get; set; } = null!;
    }
}
