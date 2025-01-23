using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Turnosplan
    {
        public int Codturno { get; set; }
        public string Descripcion { get; set; } = null!;
        public int Colorfondo { get; set; }
        public int Colortexto { get; set; }
        public DateTime Inicio1 { get; set; }
        public DateTime Fin1 { get; set; }
        public DateTime Inicio2 { get; set; }
        public DateTime Fin2 { get; set; }
        public int Visibilidad { get; set; }
    }
}
