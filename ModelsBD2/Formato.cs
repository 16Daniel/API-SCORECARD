using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Formato
    {
        public Formato()
        {
            Articulosfactporfranjas = new HashSet<Articulosfactporfranja>();
            Formatosidiomas = new HashSet<Formatosidioma>();
        }

        public int Codformato { get; set; }
        public string? Referencia { get; set; }
        public string? Descripcion { get; set; }
        public string? Combinado { get; set; }
        public double? Dosis1 { get; set; }
        public double? Dosis2 { get; set; }
        public byte[]? Imagen { get; set; }
        public byte[]? Version { get; set; }
        public double? Coste2aprox { get; set; }
        public int? Codfavorito { get; set; }

        public virtual ICollection<Articulosfactporfranja> Articulosfactporfranjas { get; set; }
        public virtual ICollection<Formatosidioma> Formatosidiomas { get; set; }
    }
}
