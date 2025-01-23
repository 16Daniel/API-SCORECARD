using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Hreservasauto
    {
        public int Idhotel { get; set; }
        public string Serie { get; set; } = null!;
        public int Idreserva { get; set; }
        public int? Semana { get; set; }
        public DateTime? Fechaentrada { get; set; }
        public DateTime? Fechasalida { get; set; }
        public int? Habitacion { get; set; }
        public int? Codempleado { get; set; }
        public DateTime? Fecha { get; set; }
    }
}
