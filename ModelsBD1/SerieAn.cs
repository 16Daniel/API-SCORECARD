using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class SerieAn
    {
        public string SerieAn1 { get; set; } = null!;
        public int Mes { get; set; }
        public int Año { get; set; }
        public decimal? Dias { get; set; }
        public decimal? PresupuestoVta { get; set; }
        public decimal? PresupuestoRotacion { get; set; }
        public decimal? Porcentaje { get; set; }
        public string? Grupo { get; set; }
    }
}
