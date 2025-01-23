using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Dissenycamposlibre
    {
        public Dissenycamposlibre()
        {
            Datosclientelibres = new HashSet<Datosclientelibre>();
        }

        public int Codrespuesta { get; set; }
        public int? Orden { get; set; }
        public string? Pregunta { get; set; }
        public int? Tipo { get; set; }
        public string? Captioninforme { get; set; }

        public virtual ICollection<Datosclientelibre> Datosclientelibres { get; set; }
    }
}
