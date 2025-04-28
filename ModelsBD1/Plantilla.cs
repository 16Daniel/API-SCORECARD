using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Plantilla
    {
        public string Tipoplantilla { get; set; } = null!;
        public string Tipocolumna { get; set; } = null!;
        public string? Titulocolumna { get; set; }
        public string? Descripcion { get; set; }
    }
}
