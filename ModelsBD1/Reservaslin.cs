using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Reservaslin
    {
        public Reservaslin()
        {
            Reservascomservs = new HashSet<Reservascomserv>();
        }

        public string Serie { get; set; } = null!;
        public int Idreserva { get; set; }
        public int Idlinea { get; set; }
        public int Idperiodo { get; set; }
        public DateTime? Desde { get; set; }
        public DateTime? Hasta { get; set; }
        public string? Regimen { get; set; }
        public int? Numpersonas { get; set; }
        public int? Supl0 { get; set; }
        public int? Supl1 { get; set; }
        public int? Supl2 { get; set; }
        public int? Supl3 { get; set; }
        public int? Supl4 { get; set; }
        public int? Supl5 { get; set; }
        public int? Supl6 { get; set; }
        public int? Supl7 { get; set; }
        public int? Supl8 { get; set; }
        public int? Supl9 { get; set; }
        public double? Uds { get; set; }
        public double? Precio { get; set; }
        public double? Precioiva { get; set; }
        public double? Preciohab { get; set; }
        public double? Preciohabiva { get; set; }
        public double? Preciodefhab { get; set; }
        public double? Preciodefhabiva { get; set; }
        public int? Pax { get; set; }
        public int? Paxdesayuno { get; set; }
        public int? Paxalmuerzo { get; set; }
        public int? Paxcena { get; set; }
        public double? Porcalojamiento { get; set; }
        public double? Porcdesayuno { get; set; }
        public double? Porcalmuerzo { get; set; }
        public double? Porccena { get; set; }

        public virtual Reserva Reserva { get; set; } = null!;
        public virtual ICollection<Reservascomserv> Reservascomservs { get; set; }
    }
}
