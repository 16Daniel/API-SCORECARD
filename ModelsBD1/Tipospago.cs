using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Tipospago
    {
        public Tipospago()
        {
            TipospagoIdiomas = new HashSet<TipospagoIdioma>();
            Vencimfpagos = new HashSet<Vencimfpago>();
            IdTienda = new HashSet<NetTiendum>();
        }

        public string Codtipopago { get; set; } = null!;
        public string? Descripcion { get; set; }
        public short? Numdiasefectivo { get; set; }
        public string? Raizcobros { get; set; }
        public string? Raizpagos { get; set; }
        public string? Metalico { get; set; }
        public string? Dllasoc { get; set; }
        public string? Visiblecobrospagos { get; set; }
        public byte[] Version { get; set; } = null!;
        public string? Cuentacobro { get; set; }
        public string? Cuentapago { get; set; }
        public string? Tarjeta { get; set; }
        public byte[]? Imagen { get; set; }
        public bool? HioposEsacredito { get; set; }
        public bool? HioposAdmitecambio { get; set; }
        public bool? HioposEntrarnumerotarjeta { get; set; }
        public bool? HioposEntrarnumerodocumento { get; set; }
        public string? HioposCodformapago { get; set; }
        public string? Marcastarjeta { get; set; }
        public string? Cashdro { get; set; }

        public virtual ICollection<TipospagoIdioma> TipospagoIdiomas { get; set; }
        public virtual ICollection<Vencimfpago> Vencimfpagos { get; set; }

        public virtual ICollection<NetTiendum> IdTienda { get; set; }
    }
}
