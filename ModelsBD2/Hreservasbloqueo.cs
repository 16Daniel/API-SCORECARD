using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Hreservasbloqueo
    {
        public int Idhotel { get; set; }
        public string Serie { get; set; } = null!;
        public int Idreserva { get; set; }
        public int Idlinea { get; set; }
        public string? Terminal { get; set; }
        public DateTime Fechainibloqueo { get; set; }
        public DateTime Horainibloqueo { get; set; }

        public virtual Hreservascab Hreservascab { get; set; } = null!;
    }
}
