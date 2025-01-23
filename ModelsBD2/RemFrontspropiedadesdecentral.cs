using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class RemFrontspropiedadesdecentral
    {
        public int Idfront { get; set; }
        public string Clave { get; set; } = null!;
        public string Subclave { get; set; } = null!;
        public string? Valor { get; set; }
    }
}
