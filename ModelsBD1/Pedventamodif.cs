using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Pedventamodif
    {
        public string Numserie { get; set; } = null!;
        public int Numpedido { get; set; }
        public string N { get; set; } = null!;
        public int Numlinea { get; set; }
        public int Fo { get; set; }
        public string Serie { get; set; } = null!;
        public short Nummodif { get; set; }
        public string? Descripcion { get; set; }
        public double? Incprecio { get; set; }
        public int? Codmodif { get; set; }
        public int? Codarticulo { get; set; }
        public short? Orden { get; set; }
        public short? Nivel { get; set; }
        public bool? Esarticulo { get; set; }
        public double? Dosis { get; set; }
        public double? Unidades { get; set; }
        public bool? Anulado { get; set; }
        public double? Incpreciobase { get; set; }

        public virtual Pedventacab NNavigation { get; set; } = null!;
    }
}
