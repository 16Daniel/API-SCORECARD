using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Clientescamposlibre
    {
        public int Codcliente { get; set; }
        public string? Serie { get; set; }
        public string? Regimen { get; set; }
        public string? Tipo { get; set; }
        public int? OrdenApp { get; set; }
        public string? Marca { get; set; }
        public string? App { get; set; }

        public virtual Cliente CodclienteNavigation { get; set; } = null!;
    }
}
