using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Cargodtohotelprecio
    {
        public int Codarticulo { get; set; }
        public int Codtarifa { get; set; }
        public int Codcliente { get; set; }
        public int Idtemporada { get; set; }
        public int Idrango { get; set; }
        public double Valor { get; set; }
        public int Valorx { get; set; }
        public byte[] Version { get; set; } = null!;
        public DateTime? Fechaentradadesde { get; set; }
        public DateTime? Fechaentradahasta { get; set; }
        public DateTime? Fechaestanciadesde { get; set; }
        public DateTime? Fechaestanciahasta { get; set; }
        public bool D1 { get; set; }
        public bool D2 { get; set; }
        public bool D3 { get; set; }
        public bool D4 { get; set; }
        public bool D5 { get; set; }
        public bool D6 { get; set; }
        public bool D7 { get; set; }
        public DateTime? Fechareservadesde { get; set; }
        public DateTime? Fechareservahasta { get; set; }
        public short Diasantelacion { get; set; }
        public short Numnoches { get; set; }
        public int? Numnochesmax { get; set; }

        public virtual Cargodtohotel CodarticuloNavigation { get; set; } = null!;
        public virtual Cliente CodclienteNavigation { get; set; } = null!;
        public virtual Tarifashotel CodtarifaNavigation { get; set; } = null!;
        public virtual Tarifashotelrango IdrangoNavigation { get; set; } = null!;
        public virtual Temporadashotel IdtemporadaNavigation { get; set; } = null!;
    }
}
