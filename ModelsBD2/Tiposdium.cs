using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Tiposdium
    {
        public int Codtipodia { get; set; }
        public string Descripcion { get; set; } = null!;
        public int Colorfondo { get; set; }
        public int Colortexto { get; set; }
    }
}
