using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class RVenta
    {
        public int Id { get; set; }
        public string Serie { get; set; } = null!;
        public int Numero { get; set; }
        public decimal? Importe { get; set; }
        public decimal? Acumulado { get; set; }
    }
}
