using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsDBP
{
    public partial class DiasEspeciale
    {
        public int Id { get; set; }
        public int Dia { get; set; }
        public int Semana { get; set; }
        public DateTime Fecha { get; set; }
        public string Descripcion { get; set; } = null!;
        public double FactorConsumo { get; set; }
    }
}
