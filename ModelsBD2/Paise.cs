using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Paise
    {
        public Paise()
        {
            Comunidades = new HashSet<Comunidade>();
        }

        public string Codpais { get; set; } = null!;
        public string? Descripcion { get; set; }
        public string? Zona { get; set; }
        public string? Descripcionpolicia { get; set; }
        public int? Iso3166 { get; set; }
        public string? Alfa3 { get; set; }

        public virtual ICollection<Comunidade> Comunidades { get; set; }
    }
}
