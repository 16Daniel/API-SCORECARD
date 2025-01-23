using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class RemRango
    {
        public int Idfront { get; set; }
        public int Tipo { get; set; }
        public bool? Puedecrear { get; set; }
        public int? Minimo { get; set; }
        public int? Maximo { get; set; }
    }
}
