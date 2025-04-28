using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Preciosventum
    {
        public int Idtarifav { get; set; }
        public int Codarticulo { get; set; }
        public string Talla { get; set; } = null!;
        public string Color { get; set; } = null!;
        public double? Pbruto { get; set; }
        public double? X { get; set; }
        public double? Y { get; set; }
        public double? Dto { get; set; }
        public double? Pneto { get; set; }
        public double? Beneficio { get; set; }
        public double? Porcc { get; set; }
        public double? Porcv { get; set; }
        public DateTime? Fechamodificado { get; set; }
        public int? Codmoneda { get; set; }
        public int Codformato { get; set; }
        public string? Dtotexto { get; set; }
        public double? Pnetoanterior { get; set; }
        public DateTime? Caducidad { get; set; }
        public double? Pbruto2 { get; set; }
        public double? Dto2 { get; set; }
        public double? Pneto2 { get; set; }
        public string? Dtotexto2 { get; set; }
        public DateTime? Desde2 { get; set; }
        public DateTime? Hasta2 { get; set; }
        public double? Porctb { get; set; }
        public bool? Descatalogado { get; set; }
        public double? Porcdef { get; set; }
        public string? Costesupuesto { get; set; }
        public byte[] Version { get; set; } = null!;

        public virtual Articuloslin Articuloslin { get; set; } = null!;
        public virtual Tarifasventum IdtarifavNavigation { get; set; } = null!;
    }
}
