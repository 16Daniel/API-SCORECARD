using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Hhabitacionesbloqueo
    {
        public int Idhotel { get; set; }
        public int Planta { get; set; }
        public int Habitacion { get; set; }
        public string? Terminal { get; set; }
        public DateTime Fechainibloqueo { get; set; }
        public DateTime Horainibloqueo { get; set; }
    }
}
