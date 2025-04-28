using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Vendedoresplanincidencium
    {
        public int Codvendedor { get; set; }
        public string Codalmacen { get; set; } = null!;
        public DateTime Fecha { get; set; }
        public int Codtipo { get; set; }
        public DateTime Inicio { get; set; }
        public DateTime Fin { get; set; }
        public string? Motivo { get; set; }
        public DateTime Dispinicio { get; set; }
        public DateTime Dispfin { get; set; }
        public double? Horas { get; set; }
        public bool? Aceptada { get; set; }
    }
}
