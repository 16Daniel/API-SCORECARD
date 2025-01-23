using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Columnaslistadosorg
    {
        public int Idcol { get; set; }
        public string Tipo { get; set; } = null!;
        public string? Descrip { get; set; }
        public string? Visible { get; set; }
        public int? Ancho { get; set; }
        public int? Orden { get; set; }
    }
}
