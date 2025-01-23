using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Moviment
    {
        public int Id { get; set; }
        public string? Codalmacenorigen { get; set; }
        public string? Codalmacendestino { get; set; }
        public string? Numserie { get; set; }
        public int Codarticulo { get; set; }
        public string Talla { get; set; } = null!;
        public string Color { get; set; } = null!;
        public double? Precio { get; set; }
        public DateTime? Fecha { get; set; }
        public DateTime? Hora { get; set; }
        public double? Codprocli { get; set; }
        public string? Tipo { get; set; }
        public double? Unidades { get; set; }
        public string? Seriedoc { get; set; }
        public double? Numdoc { get; set; }
        public string? Seriecompra { get; set; }
        public int? Numfaccompra { get; set; }
        public string? Caja { get; set; }
        public double? Stock { get; set; }
        public double? Pvp { get; set; }
        public int? Codmonedapvp { get; set; }
        public string? Calcmovpost { get; set; }
        public double? Udmedida2 { get; set; }
        public string? Zona { get; set; }
        public double? Pvpdmn { get; set; }
        public double? Preciodmn { get; set; }
        public double? Stock2 { get; set; }

        public virtual Articuloslin Articuloslin { get; set; } = null!;
    }
}
