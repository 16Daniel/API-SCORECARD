using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Historicoasunto
    {
        public int Id { get; set; }
        public string Serie { get; set; } = null!;
        public int Numero { get; set; }
        public int? Idhotel { get; set; }
        public string? Seriereserva { get; set; }
        public int? Idreserva { get; set; }
        public int? Habitacion { get; set; }
        public DateTime Fecha { get; set; }
        public int Empleado { get; set; }
        public int Tipo { get; set; }
        public string Observaciones { get; set; } = null!;

        public virtual Asunto Asunto { get; set; } = null!;
    }
}
