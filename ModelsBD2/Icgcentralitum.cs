using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Icgcentralitum
    {
        public int Idlog { get; set; }
        public DateTime? Fecha { get; set; }
        public DateTime? Horainicio { get; set; }
        public DateTime? Tiempo { get; set; }
        public int? Extension { get; set; }
        public string? Numero { get; set; }
        public int? Pasos { get; set; }
        public bool? Exportada { get; set; }
        public double? Precio { get; set; }
        public string? Tipollamada { get; set; }
        public bool? Descartada { get; set; }
    }
}
