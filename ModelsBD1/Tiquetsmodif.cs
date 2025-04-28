using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Tiquetsmodif
    {
        public short Fo { get; set; }
        public string Serie { get; set; } = null!;
        public int Numero { get; set; }
        public string N { get; set; } = null!;
        public int Numlinea { get; set; }
        public short Nummodif { get; set; }
        public string? Descripcion { get; set; }
        public double? Incprecio { get; set; }
        public int? Codmodif { get; set; }
        public int? Codarticulo { get; set; }
        public short? Orden { get; set; }
        public short? Nivel { get; set; }

        public virtual Tiquetslin Tiquetslin { get; set; } = null!;
    }
}
