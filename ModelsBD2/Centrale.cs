using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Centrale
    {
        public Centrale()
        {
            Centralespermisos = new HashSet<Centralespermiso>();
        }

        public int Idcentral { get; set; }
        public string? Descripcion { get; set; }
        public int? Tipocomunicacion { get; set; }
        public string? Ip { get; set; }
        public int? Puerto { get; set; }
        public string? Usuario { get; set; }
        public string? Password { get; set; }
        public int? Maparticulo { get; set; }
        public int? Frecuenciaexport { get; set; }
        public int? Tipoexport { get; set; }
        public int? Terminalexport { get; set; }

        public virtual ICollection<Centralespermiso> Centralespermisos { get; set; }
    }
}
