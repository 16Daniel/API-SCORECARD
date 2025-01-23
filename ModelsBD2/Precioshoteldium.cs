using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Precioshoteldium
    {
        public int Codcliente { get; set; }
        public int Codtarifa { get; set; }
        public int Codhabitacion { get; set; }
        public DateTime Dia { get; set; }
        public double? Precio { get; set; }
        public byte[]? Version { get; set; }
        public int Codregimen { get; set; }
        public int Idtemporada { get; set; }
        public double? Precioregimen { get; set; }

        public virtual Cliente CodclienteNavigation { get; set; } = null!;
        public virtual Articuloshabitacione CodhabitacionNavigation { get; set; } = null!;
        public virtual Articulosregimene CodregimenNavigation { get; set; } = null!;
        public virtual Tarifashotel CodtarifaNavigation { get; set; } = null!;
        public virtual Temporadashotel IdtemporadaNavigation { get; set; } = null!;
    }
}
