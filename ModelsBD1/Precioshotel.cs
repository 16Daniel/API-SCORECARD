using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Precioshotel
    {
        public int Codtarifa { get; set; }
        public int Idtemporada { get; set; }
        public int Codarticulo { get; set; }
        public int Codcliente { get; set; }
        public int Idrango { get; set; }
        public double? Precio { get; set; }
        public byte[]? Version { get; set; }
        public int Codhabitacion { get; set; }
        public string Tipo { get; set; } = null!;
        public short Subtipo { get; set; }
        public string? Dtotextosle { get; set; }
        public double? Produccion { get; set; }
        public double? Produccionextras { get; set; }
        public double? Produccionservicios { get; set; }

        public virtual Tarifashotel CodtarifaNavigation { get; set; } = null!;
        public virtual Tarifashotelrango IdrangoNavigation { get; set; } = null!;
        public virtual Temporadashotel IdtemporadaNavigation { get; set; } = null!;
    }
}
