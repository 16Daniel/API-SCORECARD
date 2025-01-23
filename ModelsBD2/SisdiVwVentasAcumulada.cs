using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class SisdiVwVentasAcumulada
    {
        public string Serie { get; set; } = null!;
        public DateTime? Dia { get; set; }
        public DateTime? Hora { get; set; }
        public int? Clientes { get; set; }
        public double? Precioiva { get; set; }
        public string? Ivaincluido { get; set; }
        public int Albaran { get; set; }
        public string Modo { get; set; } = null!;
        public DateTime? Ultdiahabil { get; set; }
    }
}
