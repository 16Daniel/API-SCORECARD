using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class ItRpedido
    {
        public ItRpedido()
        {
            ItRpedidosLins = new HashSet<ItRpedidosLin>();
        }

        public string Numserie { get; set; } = null!;
        public int Numpedido { get; set; }
        public string N { get; set; } = null!;
        public int? Estatus { get; set; }
        public bool Factura { get; set; }
        public bool EditoPedido { get; set; }
        public int? NumpedidoReasignado { get; set; }
        public int? NumpedidoReasignadoXml { get; set; }
        public string? Xml { get; set; }
        public byte[]? Pdf { get; set; }
        public string? XmlFileName { get; set; }
        public string? PdfFileName { get; set; }
        public string? XmlUuid { get; set; }
        public bool Excel { get; set; }
        public byte[]? ArchivoExcel { get; set; }
        public string? ExcelFileName { get; set; }
        public bool Notificacion { get; set; }
        public int? Incidencia { get; set; }
        public int Autorizacion { get; set; }
        public int? CodvendedorRecibe { get; set; }
        public DateTime? Fechapedido { get; set; }

        public virtual ICollection<ItRpedidosLin> ItRpedidosLins { get; set; }
    }
}
