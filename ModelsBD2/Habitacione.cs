using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Habitacione
    {
        public string Serie { get; set; } = null!;
        public int Tipohabitacion { get; set; }
        public int? Numero { get; set; }
        public int? Pax { get; set; }

        public virtual Series SerieNavigation { get; set; } = null!;
        public virtual Articulo1 TipohabitacionNavigation { get; set; } = null!;
    }
}
