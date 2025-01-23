using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Incidencia
    {
        public Incidencia()
        {
            Incidenciaslins = new HashSet<Incidenciaslin>();
        }

        public int Idincidencia { get; set; }
        public DateTime? Fecha { get; set; }
        public int? Tipo { get; set; }
        public int? Estado { get; set; }
        public int? Idincidenciaorig { get; set; }
        public int? Codcliente { get; set; }
        public int? Codenvio { get; set; }
        public int? Ctipodoc { get; set; }
        public string? Cserie { get; set; }
        public int? Cnumero { get; set; }
        public DateTime? Cfecha { get; set; }
        public DateTime? Cfechaentrega { get; set; }
        public string? Csupedido { get; set; }
        public int? Ccodtransporte { get; set; }
        public int? Codproveedor { get; set; }
        public int? Ptipodoc { get; set; }
        public string? Pserie { get; set; }
        public int? Pnumero { get; set; }
        public DateTime? Pfecha { get; set; }
        public int? Idmotivo { get; set; }
        public string? Comentario1 { get; set; }
        public string? Comentario2 { get; set; }
        public string? Comentario3 { get; set; }
        public double? Totalsinivacliente { get; set; }
        public double? Totalsinivacentral { get; set; }
        public double? Totalconivacliente { get; set; }
        public double? Totalconivacentral { get; set; }
        public int? Codmonedacliente { get; set; }
        public int? Codmonedacentral { get; set; }
        public string? Calculadoencentral { get; set; }
        public string? Codalmacen { get; set; }
        public int? Idfrontorig { get; set; }
        public int? Idfrontdest { get; set; }
        public string? Codalmacendestino { get; set; }

        public virtual Incidenciasnoautovalidable? Incidenciasnoautovalidable { get; set; }
        public virtual ICollection<Incidenciaslin> Incidenciaslins { get; set; }
    }
}
