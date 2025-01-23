using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Reservascuposusado
    {
        public string Serie { get; set; } = null!;
        public int Idreserva { get; set; }
        public int Idlinea { get; set; }
        public int Idperiodo { get; set; }
        public DateTime Fechainicio { get; set; }
        public DateTime Fechafin { get; set; }
        public int? Cupousado { get; set; }

        public virtual Reserva Reserva { get; set; } = null!;
    }
}
