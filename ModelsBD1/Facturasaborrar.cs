using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Facturasaborrar
    {
        public string Serie { get; set; } = null!;
        public int Numero { get; set; }
        public string N { get; set; } = null!;
        public string? Terminal { get; set; }
    }
}
