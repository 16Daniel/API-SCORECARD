using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Hreservaslincomentariosservicio
    {
        public int Idhotel { get; set; }
        public string Serie { get; set; } = null!;
        public int Idreserva { get; set; }
        public int Idlinea { get; set; }
        public int Idperiodo { get; set; }
        public int Codservicio { get; set; }
        public int Codcomentario { get; set; }
        public int? Pax { get; set; }
        public int? Paxnen { get; set; }
        public int? Paxbebe { get; set; }
        public bool? Espack { get; set; }
        public string Comentariolibre { get; set; } = null!;

        public virtual Hreservaslin Hreservaslin { get; set; } = null!;
    }
}
