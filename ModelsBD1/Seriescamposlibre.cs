using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Seriescamposlibre
    {
        public string Serie { get; set; } = null!;
        public int? Cliente { get; set; }
        public string? Cuentacontable { get; set; }
        public string? Almacen { get; set; }
        public string? Seriefa { get; set; }
        public string? Serienc { get; set; }
        public string? Webpass { get; set; }
        public int? Rasurado { get; set; }

        public virtual Series SerieNavigation { get; set; } = null!;
    }
}
