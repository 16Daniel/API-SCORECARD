using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Hserviciosregiman
    {
        public int Codigo { get; set; }
        public string Descripcion { get; set; } = null!;
        public bool Descatalogado { get; set; }
    }
}
