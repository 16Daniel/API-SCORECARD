using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Almacenesvacacione
    {
        public string Codalmacen { get; set; } = null!;
        public DateTime Fecha { get; set; }
        public string? Motivo { get; set; }
        public int Codtipodia { get; set; }
    }
}
