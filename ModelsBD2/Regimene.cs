using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Regimene
    {
        public string Codigo { get; set; } = null!;
        public string? Nombre { get; set; }
        public string? Porpersona { get; set; }
        public string? Dispalojamiento { get; set; }
        public string? Dispdesayuno { get; set; }
        public string? Dispalmuerzo { get; set; }
        public string? Dispcena { get; set; }
        public double? Porcalojamiento { get; set; }
        public double? Porcdesayuno { get; set; }
        public double? Porcalmuerzo { get; set; }
        public double? Porccena { get; set; }
    }
}
