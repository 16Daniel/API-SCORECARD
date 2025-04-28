using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class ItRpedidosLin
    {
        public string Numserie { get; set; } = null!;
        public int Numpedido { get; set; }
        public string N { get; set; } = null!;
        public int Codarticulo { get; set; }
        public string Referencia { get; set; } = null!;
        public int? CbMotivo { get; set; }
        public string? MsgMotivo { get; set; }
        public double? Unid1 { get; set; }
        public double? Unid2 { get; set; }
        public double? Unidadestotal { get; set; }
        public double? Unidadesrec { get; set; }
        public double? Unidadespen { get; set; }
        public int Autorizacion { get; set; }
        public int? NumpedidoReasignado { get; set; }
        public double? PrecioProveedor { get; set; }
        public double? UnidadesProveedor { get; set; }

        public virtual ItRpedido NNavigation { get; set; } = null!;
    }
}
