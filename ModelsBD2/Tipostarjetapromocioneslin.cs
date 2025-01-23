using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Tipostarjetapromocioneslin
    {
        public int Idtipotarjeta { get; set; }
        public int Idfront { get; set; }
        public int Idlinea { get; set; }
        public int? Puntos { get; set; }
        public double? Consumiciones { get; set; }
        public double? Importe { get; set; }
        public int? Tickets { get; set; }
        public string? Textoaviso { get; set; }
        public DateTime? Caducidad { get; set; }
        public bool? Darsoloregalos { get; set; }

        public virtual Tipostarjetapromocione Id { get; set; } = null!;
    }
}
