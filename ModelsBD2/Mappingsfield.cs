using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Mappingsfield
    {
        public int Idmap { get; set; }
        public int Idfile { get; set; }
        public int Idfield { get; set; }
        public int? Posicion { get; set; }
        public int? Tipofield { get; set; }
        public string? Fieldname { get; set; }
        public int? Fieldsize { get; set; }
        public int? Numdigitosdecimales { get; set; }
        public string? Formatofecha { get; set; }
        public string? Tagxml { get; set; }
        public string? Documentacion { get; set; }
        public string? Esatributo { get; set; }
        public string? Iscampoclave { get; set; }
        public string? Sumable { get; set; }
        public int? Ordenimportacion { get; set; }

        public virtual Mappingsfile Id { get; set; } = null!;
    }
}
