using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Articulosentrada
    {
        public int Codarticulo { get; set; }
        public DateTime? Fechainicio { get; set; }
        public DateTime? Fechafin { get; set; }
        public int? Numentradasdia { get; set; }
        public int? Pax { get; set; }
        public byte? Vigencia { get; set; }
        public bool? Identsalida { get; set; }
        public bool? Identhuella { get; set; }
        public int? Diasvigencia { get; set; }
        public byte[]? Version { get; set; }
        public int? Numsesiones { get; set; }

        public virtual Articulo1 CodarticuloNavigation { get; set; } = null!;
    }
}
