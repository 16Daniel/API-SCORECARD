using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class SemanasCtovtum
    {
        public int Semana { get; set; }
        public int Mes { get; set; }
        public int Año { get; set; }
        public int DiaInicio { get; set; }
        public int DiaFin { get; set; }
        public string Grupo { get; set; } = null!;
    }
}
