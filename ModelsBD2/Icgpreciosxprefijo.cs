using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Icgpreciosxprefijo
    {
        public string Prefijo { get; set; } = null!;
        public double? Precio { get; set; }
        public double? CargoInicial { get; set; }
    }
}
