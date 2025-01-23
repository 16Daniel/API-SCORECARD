using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Mapping
    {
        public Mapping()
        {
            Mappingslins = new HashSet<Mappingslin>();
        }

        public int Idmap { get; set; }
        public int? Idtipo { get; set; }
        public string? Nombre { get; set; }
        public string? Delimitador { get; set; }
        public bool? Haydel { get; set; }
        public int? Lineaini { get; set; }
        public string? Separadordecimal { get; set; }
        public bool? Hayseparador { get; set; }
        public string? Formatofecha { get; set; }
        public int? Importarcodbarras { get; set; }

        public virtual ICollection<Mappingslin> Mappingslins { get; set; }
    }
}
