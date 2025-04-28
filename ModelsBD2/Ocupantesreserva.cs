using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Ocupantesreserva
    {
        public string Serie { get; set; } = null!;
        public int Idreserva { get; set; }
        public int Idlinea { get; set; }
        public int Orden { get; set; }
        public string? Nompersona { get; set; }
        public string? Nombre1 { get; set; }
        public string? Apellido1 { get; set; }
        public string? Apellido2 { get; set; }
        public string? Nif20 { get; set; }

        public virtual Reserva Reserva { get; set; } = null!;
    }
}
