using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Ventascashdrotesorerium
    {
        public string Serie { get; set; } = null!;
        public int Numero { get; set; }
        public string N { get; set; } = null!;
        public double Importe { get; set; }
        public string? Enlace { get; set; }
    }
}
