using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Venta
    {
        public string? Db { get; set; }
        public string Titulo { get; set; } = null!;
        public int Importe { get; set; }
    }
}
