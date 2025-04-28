using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Precioscompra
    {
        public int Codproveedor { get; set; }
        public int Idtarifac { get; set; }
        public string N { get; set; } = null!;
        public int Codarticulo { get; set; }
        public string Talla { get; set; } = null!;
        public string Color { get; set; } = null!;
        public double? Pbruto { get; set; }
        public double X { get; set; }
        public double? Y { get; set; }
        public double? Dto { get; set; }
        public double? Totaldto { get; set; }
        public double? Pneto { get; set; }
        public DateTime? Fechamodificado { get; set; }
        public int? Codmoneda { get; set; }
        public string? Dtotexto { get; set; }
        public byte[] Version { get; set; } = null!;
        public double? Pnetoanterior { get; set; }
        public int Codformato { get; set; }

        public virtual Articuloslin Articuloslin { get; set; } = null!;
        public virtual Tarifascompra Tarifascompra { get; set; } = null!;
    }
}
