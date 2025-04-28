using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Articulosdiarioscliente
    {
        public int Codcliente { get; set; }
        public int Numlinea { get; set; }
        public string? Referencia { get; set; }
        public int? Codarticulo { get; set; }
        public string? Talla { get; set; }
        public string? Color { get; set; }
        public string? Descripcion { get; set; }
        public string? Serie { get; set; }
        public double? Lunes { get; set; }
        public double? Martes { get; set; }
        public double? Miercoles { get; set; }
        public double? Jueves { get; set; }
        public double? Viernes { get; set; }
        public double? Sabado { get; set; }
        public double? Domingo { get; set; }
        public DateTime? Desde { get; set; }
        public DateTime? Hasta { get; set; }

        public virtual Cliente CodclienteNavigation { get; set; } = null!;
    }
}
