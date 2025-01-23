using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Tiquetscab
    {
        public Tiquetscab()
        {
            Tiquetslins = new HashSet<Tiquetslin>();
            Tiquetspags = new HashSet<Tiquetspag>();
        }

        public short Fo { get; set; }
        public string Serie { get; set; } = null!;
        public int Numero { get; set; }
        public string N { get; set; } = null!;
        public int? Numfactura { get; set; }
        public short? Sala { get; set; }
        public short? Mesa { get; set; }
        public DateTime? Fecha { get; set; }
        public DateTime? Horaini { get; set; }
        public DateTime? Horafin { get; set; }
        public short? Diasemana { get; set; }
        public double? Codcliente { get; set; }
        public double? Codvendedor { get; set; }
        public short? Numcomensales { get; set; }
        public short? Caja { get; set; }
        public double? Totalcoste { get; set; }
        public double? Totalbruto { get; set; }
        public double? Cargo { get; set; }
        public double? Totalneto { get; set; }
        public double? Z { get; set; }
        public string? Ivainc { get; set; }
        public int? Codtarifa { get; set; }
        public string? Esbarra { get; set; }
        public string? Subtotal { get; set; }
        public short? Impresiones { get; set; }
        public double? Baseimp1 { get; set; }
        public short? Codtipotasa1 { get; set; }
        public double? Cuotatasa1 { get; set; }
        public double? Baseimp2 { get; set; }
        public short? Codtipotasa2 { get; set; }
        public double? Cuotatasa2 { get; set; }
        public double? Baseimp3 { get; set; }
        public short? Codtipotasa3 { get; set; }
        public double? Cuotatasa3 { get; set; }
        public double? Baseimp4 { get; set; }
        public short? Codtipotasa4 { get; set; }
        public double? Cuotatasa4 { get; set; }
        public double? Baseimp5 { get; set; }
        public short? Codtipotasa5 { get; set; }
        public double? Cuotatasa5 { get; set; }
        public double? Baseimp6 { get; set; }
        public short? Codtipotasa6 { get; set; }
        public double? Cuotatasa6 { get; set; }
        public string? Automatico { get; set; }

        public virtual ICollection<Tiquetslin> Tiquetslins { get; set; }
        public virtual ICollection<Tiquetspag> Tiquetspags { get; set; }
    }
}
