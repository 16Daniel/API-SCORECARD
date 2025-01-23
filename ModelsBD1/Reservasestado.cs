using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Reservasestado
    {
        public string Serie { get; set; } = null!;
        public int Idreserva { get; set; }
        public int Idlinea { get; set; }
        public int Tipo { get; set; }
        public string Codestado { get; set; } = null!;
        public int Dias { get; set; }

        public virtual Reserva Reserva { get; set; } = null!;
    }
}
