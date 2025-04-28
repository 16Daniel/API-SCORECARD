using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Presupuestoslin
    {
        public string Numserie { get; set; } = null!;
        public int Numpresupuesto { get; set; }
        public string N { get; set; } = null!;
        public int Version { get; set; }
        public int Numlinea { get; set; }
        public int? Codarticulo { get; set; }
        public string? Referencia { get; set; }
        public string? Descripcion { get; set; }
        public string Talla { get; set; } = null!;
        public string Color { get; set; } = null!;
        public double? Unid1 { get; set; }
        public double? Unid2 { get; set; }
        public double? Unid3 { get; set; }
        public double? Unid4 { get; set; }
        public double? Unidadestotal { get; set; }
        public double? Precio { get; set; }
        public double? Dto { get; set; }
        public double? Total { get; set; }
        public double? Preciodefecto { get; set; }
        public short? Tipoimpuesto { get; set; }
        public double? Iva { get; set; }
        public double? Req { get; set; }
        public double? Numkg { get; set; }
        public double? Coste { get; set; }
        public int? Codtarifa { get; set; }
        public int? Codvendedor { get; set; }
        public double? Costeiva { get; set; }
        public int? Idpartida { get; set; }
        public string? Supedido { get; set; }
        public int? Estado { get; set; }
        public double? Cargo1 { get; set; }
        public double? Cargo2 { get; set; }
        public double? Udmedida2 { get; set; }

        public virtual Presupuestoscab Presupuestoscab { get; set; } = null!;
    }
}
