using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Codigopostal
    {
        public int Idcodpostal { get; set; }
        public string Codpostal { get; set; } = null!;
        public string Codpais { get; set; } = null!;
        public string? Provincia { get; set; }
        public string? Poblacion { get; set; }
        public string? Zona { get; set; }
    }
}
