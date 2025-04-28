using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsDashboard
{
    public partial class Diferencia
    {
        public string? Cod { get; set; }
        public string? Region { get; set; }
        public string? Sucursal { get; set; }
        public int? Codart { get; set; }
        public string? Articulo { get; set; }
        public string? InvAyer { get; set; }
        public string? InvHoy { get; set; }
        public string? InvFormula { get; set; }
        public string? Diferencia1 { get; set; }
        public DateTime? Fecha { get; set; }
        public int? Semana { get; set; }
    }
}
