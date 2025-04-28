using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Asuntosarticulo
    {
        public string Serie { get; set; } = null!;
        public int Numero { get; set; }
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
        public int? Tipoactividad { get; set; }
        public double? Idintervencion { get; set; }
        public byte[] Version { get; set; } = null!;
        public int? Idhotelocupante { get; set; }
        public string? Serieocupante { get; set; }
        public int? Idreservaocupante { get; set; }
        public int? Idlineaocupante { get; set; }
        public int? Ordenocupante { get; set; }
        public bool? Espaquete { get; set; }
        public int? Idpaqueterel { get; set; }
        public int? Idtemporada { get; set; }
        public int? Idrango { get; set; }
        public string? Serieres { get; set; }
        public int? Numerores { get; set; }
        public string? Nres { get; set; }
        public string? Seriealb { get; set; }
        public int? Numeroalb { get; set; }
        public string? Nalb { get; set; }
        public int? Numlinalb { get; set; }
        public string? Identificadorabono { get; set; }

        public virtual Asunto Asunto { get; set; } = null!;
    }
}
