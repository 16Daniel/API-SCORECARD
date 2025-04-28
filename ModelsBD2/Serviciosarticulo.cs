using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Serviciosarticulo
    {
        public string Serie { get; set; } = null!;
        public int Numero { get; set; }
        public double Idintervencion { get; set; }
        public int Idlin { get; set; }
        public int? Codarticulo { get; set; }
        public string? Talla { get; set; }
        public string? Color { get; set; }
        public string? Referencia { get; set; }
        public string? Descripcion { get; set; }
        public double? Unidades { get; set; }
        public string? Codalmacen { get; set; }
        public int? Idtarifav { get; set; }
        public double? Precio { get; set; }
        public double? Precioiva { get; set; }
        public double? Preciodefecto { get; set; }
        public double? Factormoneda { get; set; }
        public double? Dto { get; set; }
        public int? Tipoimpuesto { get; set; }
        public double? Iva { get; set; }
        public double? Req { get; set; }
        public double? Importe { get; set; }
        public double? Importeiva { get; set; }
        public int? Codmoneda { get; set; }
        public string? Seriefac { get; set; }
        public int? Numerofac { get; set; }
        public string? Nfac { get; set; }
        public DateTime? Fechafac { get; set; }
        public int? Codcliente { get; set; }
        public string? Facturado { get; set; }
        public DateTime? Desde { get; set; }
        public int? Idlinea { get; set; }

        public virtual Servicio Servicio { get; set; } = null!;
    }
}
