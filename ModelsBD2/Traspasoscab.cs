using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Traspasoscab
    {
        public Traspasoscab()
        {
            Traspasosfirmas = new HashSet<Traspasosfirma>();
        }

        public string Serie { get; set; } = null!;
        public int Numero { get; set; }
        public string Caja { get; set; } = null!;
        public DateTime? Fecha { get; set; }
        public string? Codalmacenorigen { get; set; }
        public string? Codalmacendestino { get; set; }
        public string? Seriecompra { get; set; }
        public int? Numfaccompra { get; set; }
        public string? Contabilizado { get; set; }
        public double? Total { get; set; }
        public string? Anulado { get; set; }
        public string? Serieanulado { get; set; }
        public string? Cajaanulado { get; set; }
        public int? Numeroanulado { get; set; }
        public string? Recibido { get; set; }
        public DateTime? Fecharecibido { get; set; }
        public string? Identificador { get; set; }
        public int? Recibidoporcodvendedor { get; set; }
        public string? Descargado { get; set; }
        public string? Observaciones { get; set; }
        public double? Totaldmn { get; set; }
        public string? Esautomatico { get; set; }
        public string? Esrecuento { get; set; }
        public string? Esajuste { get; set; }
        public string? Cuentagastosexistencias { get; set; }
        public string? Cuentagastosexistenciasdmn { get; set; }
        public int? Idconceptoajuste { get; set; }
        public int? Idconceptoajustedmn { get; set; }
        public string? Escontabilizable { get; set; }
        public DateTime? Fechaanulado { get; set; }
        public string? Serieventa { get; set; }
        public int? Numfacventa { get; set; }
        public DateTime? Fechacreacion { get; set; }
        public int? Impresiones { get; set; }
        public DateTime? Fechatransporte { get; set; }
        public string? Modificable { get; set; }
        public int? Idmotivo { get; set; }
        public string? Descmotivo { get; set; }
        public string? Estransporte { get; set; }

        public virtual ICollection<Traspasosfirma> Traspasosfirmas { get; set; }
    }
}
