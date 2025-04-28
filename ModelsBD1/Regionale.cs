using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Regionale
    {
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public string? Sucursal { get; set; }
        public TimeSpan? Hora { get; set; }
    }
}
