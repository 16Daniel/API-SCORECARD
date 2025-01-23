using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Aeropuerto
    {
        public string Codigo { get; set; } = null!;
        public string? Descripcion { get; set; }
        public string? Ciudad { get; set; }
        public string? Codpais { get; set; }
        public string? Descpais { get; set; }
        public string? Schengen { get; set; }
        public string? Unioneuropea { get; set; }
    }
}
