using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Seriescamposlibre
    {
        public string Serie { get; set; } = null!;
        public string? Franquicia { get; set; }
        public string? Consulta1 { get; set; }
        public string? Consulta2 { get; set; }
        public int? Cliente { get; set; }
        public string? Cuentacontable { get; set; }
        public string? Seriefa { get; set; }
        public string? Serienc { get; set; }
        public string? Webpass { get; set; }
        public int? Rasurado { get; set; }
        public string? Region { get; set; }

        public virtual Series SerieNavigation { get; set; } = null!;
    }
}
