using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class ItRcalLin
    {
        public string Numserie { get; set; } = null!;
        public int Numpedido { get; set; }
        public string N { get; set; } = null!;
        public int Numlinea { get; set; }
        public string Usuario { get; set; } = null!;
        public double? Unid1 { get; set; }
        public double? Unid2 { get; set; }
        public double? Unidadestotal { get; set; }
        public double? Unidadesrec { get; set; }
        public double? Unidadespen { get; set; }
        public int? Codarticulo { get; set; }
        public string? Referencia { get; set; }
        public string? Descripcion { get; set; }
        public string? Color { get; set; }
        public string? Talla { get; set; }
        public double? Precio { get; set; }
        public double? Dto { get; set; }
        public short? Tipoimpuesto { get; set; }
        public double? Iva { get; set; }
        public double? Req { get; set; }
        public string? Codalmacen { get; set; }
        public int? Codproveedor { get; set; }
        public string? Almacen { get; set; }
    }
}
