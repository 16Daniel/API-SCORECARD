using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Mediospagohiopo
    {
        public long Idmediopago { get; set; }
        public string? Descripcion { get; set; }
        public bool? Esmetalico { get; set; }
        public bool? Esacredito { get; set; }
        public bool? Necesitacomprobante { get; set; }
        public byte[]? Imagen { get; set; }
        public bool? Descatalogado { get; set; }
        public string? Dispositivocobroelectronico { get; set; }
        public string? Tipocobroelectronico { get; set; }
        public string? Retornocobroelectronico { get; set; }
        public bool? Admitecambio { get; set; }
        public bool? Entrarnumerotarjeta { get; set; }
        public bool? Entrarnumerodocumento { get; set; }
        public byte[] Version { get; set; } = null!;
        public long? Versioninsert { get; set; }
    }
}
