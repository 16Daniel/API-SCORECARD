using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Ticketslin
    {
        public short Fo { get; set; }
        public string Serie { get; set; } = null!;
        public int Numero { get; set; }
        public string N { get; set; } = null!;
        public int Numlinea { get; set; }
        public int? Codarticulo { get; set; }
        public string Talla { get; set; } = null!;
        public string Color { get; set; } = null!;
        public string? Descripcion { get; set; }
        public double? Coste { get; set; }
        public double? Unidades { get; set; }
        public double? Precio { get; set; }
        public double? Precioiva { get; set; }
        public double? Preciodefecto { get; set; }
        public double? Codvendedor { get; set; }
        public string? Tipo { get; set; }
        public short? Tipoiva { get; set; }
        public int? Codoferta { get; set; }
        public double? Dto { get; set; }
        public string? Referencia { get; set; }
    }
}
