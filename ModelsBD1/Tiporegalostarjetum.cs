using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Tiporegalostarjetum
    {
        public int Id { get; set; }
        public int Idlinea { get; set; }
        public int? Puntos { get; set; }
        public double? Consumiciones { get; set; }
        public double? Importe { get; set; }
        public int? Tickets { get; set; }
        public string? Textoaviso { get; set; }
        public DateTime? Caducidad { get; set; }

        public virtual Tipotarjetascliente IdNavigation { get; set; } = null!;
    }
}
