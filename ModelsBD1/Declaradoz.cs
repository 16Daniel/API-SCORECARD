using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Declaradoz
    {
        public int Tipo { get; set; }
        public string Caja { get; set; } = null!;
        public int Numz { get; set; }
        public int Codmoneda { get; set; }
        public double Importe { get; set; }
        public string Codmediopago { get; set; } = null!;
        public string? Observaciones { get; set; }
        public int? Idmotivo { get; set; }
        public bool? Auto { get; set; }
    }
}
