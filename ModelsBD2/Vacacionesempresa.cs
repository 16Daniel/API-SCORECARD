using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Vacacionesempresa
    {
        public int Codempresa { get; set; }
        public int Codvaclin { get; set; }
        public DateTime Desde { get; set; }
        public DateTime Hasta { get; set; }
        public string? Motivo { get; set; }
    }
}
