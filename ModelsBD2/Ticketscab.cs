using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Ticketscab
    {
        public Ticketscab()
        {
            Tiquetslins = new HashSet<Tiquetslin>();
            Tiquetspags = new HashSet<Tiquetspag>();
        }

        public short Fo { get; set; }
        public string Serie { get; set; } = null!;
        public int Numero { get; set; }
        public string N { get; set; } = null!;
        public DateTime? Fecha { get; set; }
        public DateTime? Hora { get; set; }
        public short? Diasemana { get; set; }
        public double? Codcliente { get; set; }
        public double? Codvendedor { get; set; }
        public short? Caja { get; set; }
        public double? Totalcoste { get; set; }
        public double? Totalbruto { get; set; }
        public double? Cargo { get; set; }
        public double? Totalneto { get; set; }
        public double? Baseimp1 { get; set; }
        public double? Porciva1 { get; set; }
        public double? Iva1 { get; set; }
        public double? Porcreq1 { get; set; }
        public double? Req1 { get; set; }
        public double? Baseimp2 { get; set; }
        public double? Porciva2 { get; set; }
        public double? Iva2 { get; set; }
        public double? Porcreq2 { get; set; }
        public double? Req2 { get; set; }
        public double? Baseimp3 { get; set; }
        public double? Porciva3 { get; set; }
        public double? Iva3 { get; set; }
        public double? Porcreq3 { get; set; }
        public double? Req3 { get; set; }
        public double? Z { get; set; }
        public string? Ivainc { get; set; }
        public int? Codtarifa { get; set; }
        public int? Numfactura { get; set; }
        public string? Automatico { get; set; }
        public short? Impresiones { get; set; }

        public virtual ICollection<Tiquetslin> Tiquetslins { get; set; }
        public virtual ICollection<Tiquetspag> Tiquetspags { get; set; }
    }
}
