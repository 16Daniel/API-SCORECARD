using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class RemPedtemplin
    {
        public int Idpedido { get; set; }
        public int Idlinea { get; set; }
        public int? Codarticulo { get; set; }
        public string? Talla { get; set; }
        public string? Color { get; set; }
        public double? Unid1 { get; set; }
        public double? Unid2 { get; set; }
        public double? Unid3 { get; set; }
        public double? Unid4 { get; set; }
        public double? Precio { get; set; }
        public double? Dto { get; set; }
        public double? Unidaltern { get; set; }

        public virtual RemPedtempcab IdpedidoNavigation { get; set; } = null!;
    }
}
