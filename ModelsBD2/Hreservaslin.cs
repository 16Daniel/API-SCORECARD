using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Hreservaslin
    {
        public Hreservaslin()
        {
            Hreservascargos = new HashSet<Hreservascargo>();
            Hreservaslincomentariosservicios = new HashSet<Hreservaslincomentariosservicio>();
        }

        public int Idhotel { get; set; }
        public string Serie { get; set; } = null!;
        public int Idreserva { get; set; }
        public int Idlinea { get; set; }
        public int Idperiodo { get; set; }
        public DateTime? Desde { get; set; }
        public DateTime? Hasta { get; set; }
        public int? Codregimen { get; set; }
        public int? Numpersonas { get; set; }
        public double? Uds { get; set; }
        public int? Pax { get; set; }
        public int? Paxnen { get; set; }
        public int? Paxbebe { get; set; }
        public int? Paxdesayuno { get; set; }
        public int? Paxalmuerzo { get; set; }
        public int? Paxcena { get; set; }
        public int? Paxdesayunonen { get; set; }
        public int? Paxalmuerzonen { get; set; }
        public int? Paxcenanen { get; set; }
        public int? Paxdesayunobebe { get; set; }
        public int? Paxalmuerzobebe { get; set; }
        public int? Paxcenabebe { get; set; }
        public int? Apaxdesayuno { get; set; }
        public int? Apaxalmuerzo { get; set; }
        public int? Apaxcena { get; set; }
        public int? Apaxdesayunonen { get; set; }
        public int? Apaxalmuerzonen { get; set; }
        public int? Apaxcenanen { get; set; }
        public int? Apaxdesayunobebe { get; set; }
        public int? Apaxalmuerzobebe { get; set; }
        public int? Apaxcenabebe { get; set; }
        public int? Primerservicio { get; set; }
        public double? Porcalojamiento { get; set; }
        public double? Porcdesayuno { get; set; }
        public double? Porcalmuerzo { get; set; }
        public double? Porccena { get; set; }
        public string? Regimen { get; set; }
        public double? Porcdtonen { get; set; }
        public double? Porcdtobebe { get; set; }
        public int? Idcupo { get; set; }
        public double? Importeprodalojamiento { get; set; }
        public double? Importeproddesayuno { get; set; }
        public double? Importeprodalmuerzo { get; set; }
        public double? Importeprodcena { get; set; }
        public double? Importeivaprodalojamiento { get; set; }
        public double? Importeivaproddesayuno { get; set; }
        public double? Importeivaprodalmuerzo { get; set; }
        public double? Importeivaprodcena { get; set; }
        public int? Idtarifa { get; set; }
        public int? Idlineacambiohabitacion { get; set; }

        public virtual Hreserva Hreserva { get; set; } = null!;
        public virtual ICollection<Hreservascargo> Hreservascargos { get; set; }
        public virtual ICollection<Hreservaslincomentariosservicio> Hreservaslincomentariosservicios { get; set; }
    }
}
