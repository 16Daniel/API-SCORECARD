using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Vocclientesreserva
    {
        public string? Nombre { get; set; }
        public string? Nif { get; set; }
        public int? Codcliente { get; set; }
        public int Escliente { get; set; }
        public int Esagencia { get; set; }
        public int Espersona { get; set; }
        public int Idhotel { get; set; }
        public string Serie { get; set; } = null!;
        public int Idreserva { get; set; }
        public int Idlinea { get; set; }
    }
}
