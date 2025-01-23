using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Desgloseefectivoporz
    {
        public int Fo { get; set; }
        public string Caja { get; set; } = null!;
        public int Z { get; set; }
        public string N { get; set; } = null!;
        public int Cuenta { get; set; }
        public double? Importe { get; set; }
    }
}
