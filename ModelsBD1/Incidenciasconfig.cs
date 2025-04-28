using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Incidenciasconfig
    {
        public int Tipo { get; set; }
        public int Estado { get; set; }
        public int? Tipodocumento { get; set; }
        public string? Codalmacen { get; set; }
    }
}
