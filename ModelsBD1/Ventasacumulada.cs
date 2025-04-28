using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Ventasacumulada
    {
        public int Anyo { get; set; }
        public int Mes { get; set; }
        public string Numserie { get; set; } = null!;
        public int Codcliente { get; set; }
        public int Codvendedor { get; set; }
        public string Codalmacen { get; set; } = null!;
        public int Codarticulo { get; set; }
        public string Talla { get; set; } = null!;
        public string Color { get; set; } = null!;
        public string N { get; set; } = null!;
        public double? Unidades { get; set; }
        public double? Unidadesalternativas { get; set; }
        public double? Importe { get; set; }
        public double? Importeiva { get; set; }
        public double? Coste { get; set; }
        public double? Costeiva { get; set; }
        public int Id { get; set; }
        public int? Anyomes { get; set; }
        public double? Udmedida2 { get; set; }
        public double? Importepromocion { get; set; }
        public double? Importepromocioniva { get; set; }
        public string? Importado { get; set; }
        public int Codmoneda { get; set; }
        public double? Importedoc { get; set; }
        public double? Importeivadoc { get; set; }
        public double? Costedoc { get; set; }
        public double? Costeivadoc { get; set; }
    }
}
