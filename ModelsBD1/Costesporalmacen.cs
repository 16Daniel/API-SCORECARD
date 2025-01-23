using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Costesporalmacen
    {
        public string Codalmacen { get; set; } = null!;
        public int Codarticulo { get; set; }
        public string Talla { get; set; } = null!;
        public string Color { get; set; } = null!;
        public double? Costemedio { get; set; }
        public double? Costestock { get; set; }
        public double? Ultimocoste { get; set; }
        public double? Precioultcompra { get; set; }
        public double? Ultdesccomercial { get; set; }
        public double? Unidadescompradas { get; set; }
        public DateTime? Fechaultcompra { get; set; }
        public double? Ultdtocomercial { get; set; }
        public double? Preciocomprareal { get; set; }
        public int? Codmoneda { get; set; }
        public double? Costemediodmn { get; set; }
        public double? Costestockdmn { get; set; }
        public double? Ultimocostedmn { get; set; }
        public double? Precioultcompradmn { get; set; }
        public double? Preciocomprarealdmn { get; set; }
        public double? Ultdesccomercialdmn { get; set; }
        public double? Ultdtocomercialdmn { get; set; }
        public int? Codmonedadmn { get; set; }
        public double? Unidadescompradasdmn { get; set; }
        public double? Importecargo1 { get; set; }
        public double? Importecargo2 { get; set; }
        public double? Importecargo1dmn { get; set; }
        public double? Importecargo2dmn { get; set; }
        public byte[]? Version { get; set; }

        public virtual Articuloslin Articuloslin { get; set; } = null!;
    }
}
