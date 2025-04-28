using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Mappingscab
    {
        public Mappingscab()
        {
            Mappingsficherosrelacionados = new HashSet<Mappingsficherosrelacionado>();
            Mappingsfiles = new HashSet<Mappingsfile>();
            Mappingsidimportacions = new HashSet<Mappingsidimportacion>();
            Mappingspropiedades = new HashSet<Mappingspropiedade>();
            Mappingsreglas = new HashSet<Mappingsregla>();
            Mappingssqls = new HashSet<Mappingssql>();
        }

        public int Idmap { get; set; }
        public int? Idtipo { get; set; }
        public string? Nombre { get; set; }
        public string? Visible { get; set; }
        public string? Remesa { get; set; }
        public int? Norma { get; set; }

        public virtual ICollection<Mappingsficherosrelacionado> Mappingsficherosrelacionados { get; set; }
        public virtual ICollection<Mappingsfile> Mappingsfiles { get; set; }
        public virtual ICollection<Mappingsidimportacion> Mappingsidimportacions { get; set; }
        public virtual ICollection<Mappingspropiedade> Mappingspropiedades { get; set; }
        public virtual ICollection<Mappingsregla> Mappingsreglas { get; set; }
        public virtual ICollection<Mappingssql> Mappingssqls { get; set; }
    }
}
