using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Vproduccion
    {
        public int Idhotel { get; set; }
        public string Serie { get; set; } = null!;
        public int Idreserva { get; set; }
        public int Idlinea { get; set; }
        public DateTime Desde { get; set; }
        public double? Importeprodalojamiento { get; set; }
        public double? Importeproddesayuno { get; set; }
        public double? Importeprodalmuerzo { get; set; }
        public double? Importeprodcena { get; set; }
        public double? Importeivaprodalojamiento { get; set; }
        public double? Importeivaproddesayuno { get; set; }
        public double? Importeivaprodalmuerzo { get; set; }
        public double? Importeivaprodcena { get; set; }
    }
}
