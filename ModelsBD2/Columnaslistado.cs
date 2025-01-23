using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Columnaslistado
    {
        public int Tipo { get; set; }
        public int Idcol { get; set; }
        public string? Nombrecol { get; set; }
        public string? Tipocol { get; set; }
        public int? Ancho { get; set; }
        public int? Decimales { get; set; }
    }
}
