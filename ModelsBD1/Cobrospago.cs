using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Cobrospago
    {
        public short Fo { get; set; }
        public short Caja { get; set; }
        public short Tipo { get; set; }
        public int Numero { get; set; }
        public string N { get; set; } = null!;
        public DateTime? Fecha { get; set; }
        public DateTime? Hora { get; set; }
        public int? Codvendedor { get; set; }
        public short? Codigo { get; set; }
        public string? Codformapago { get; set; }
        public double? Importe { get; set; }
        public int? Codmoneda { get; set; }
        public double? Factor { get; set; }
        public string? Comentario { get; set; }
        public int? Z { get; set; }
        public int? Codcliente { get; set; }
        public short? Fofactura { get; set; }
        public short? Cajafactura { get; set; }
        public int? Numfactura { get; set; }
        public int? Numtiquet { get; set; }
        public short? Numvencim { get; set; }
        public int? Venorigen { get; set; }
        public int? Venpendiente { get; set; }
        public DateTime? Fechatiquet { get; set; }
        public string? Cajastr { get; set; }
        public string Cajaorigen { get; set; } = null!;
    }
}
