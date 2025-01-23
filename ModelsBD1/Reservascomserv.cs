using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Reservascomserv
    {
        public string Serie { get; set; } = null!;
        public int Idreserva { get; set; }
        public int Idlinea { get; set; }
        public int Idperiodo { get; set; }
        public int Codservicio { get; set; }
        public int Codcomentario { get; set; }
        public int? Pax { get; set; }

        public virtual Reservaslin Reservaslin { get; set; } = null!;
    }
}
