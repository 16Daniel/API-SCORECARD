using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Tarifashotelextra
    {
        public int Codtarifa { get; set; }
        public int Iddia { get; set; }
        public int Numlin { get; set; }
        public int? Codarticulo { get; set; }
        public string? Talla { get; set; }
        public string? Color { get; set; }
        public string? Descripcion { get; set; }
        public double? Precio { get; set; }
        public int? Codimpuesto { get; set; }
        public double? Iva { get; set; }
        public double? Req { get; set; }
        public double? Precioiva { get; set; }
        public double? Uds { get; set; }
        public int? Aplicarpor { get; set; }
        public bool? Cocina { get; set; }
        public int? Notascocina { get; set; }
        public bool? Opcional { get; set; }
        public int? Incluido { get; set; }
        public string? Estadoautomatico { get; set; }
        public int? Intervaloestadoauto { get; set; }
        public int? Diaestadoauto { get; set; }
        public int? Tipohabitacion { get; set; }

        public virtual Tarifashotel CodtarifaNavigation { get; set; } = null!;
    }
}
