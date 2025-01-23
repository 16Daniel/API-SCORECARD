using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Vocclientesactividade
    {
        public string? Nombre { get; set; }
        public string? Nif { get; set; }
        public int Codcliente { get; set; }
        public int? Idhotel { get; set; }
        public string Serie { get; set; } = null!;
        public int Numero { get; set; }
        public double? Idintervencion { get; set; }
    }
}
