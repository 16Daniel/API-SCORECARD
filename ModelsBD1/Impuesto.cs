using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Impuesto
    {
        public Impuesto()
        {
            IdTienda = new HashSet<NetTiendum>();
        }

        public int Tipoiva { get; set; }
        public string? Descripcion { get; set; }
        public double? Iva { get; set; }
        public double? Req { get; set; }
        public double? Cuota { get; set; }
        public string? Cuentaivarep { get; set; }
        public string? Cuentaivasop { get; set; }
        public string? Cuentarecrep { get; set; }
        public string? Cuentarecsop { get; set; }
        public int? Aplicaciontasa2 { get; set; }
        public int? Tipoivarelacionado { get; set; }
        public byte[]? Version { get; set; }
        public string? Codigoimpuesto { get; set; }
        public DateTime? Futurodesde1 { get; set; }
        public double? Futuroiva1 { get; set; }
        public double? Futuroreq1 { get; set; }
        public DateTime? Futurodesde2 { get; set; }
        public double? Futuroiva2 { get; set; }
        public double? Futuroreq2 { get; set; }
        public string? Cuentaivasopdevol { get; set; }
        public string? Cuentaivarepdevol { get; set; }
        public string? Motexencion { get; set; }
        public int? TipoImpuestoAena { get; set; }
        public string? DescTipoImpuestoAena { get; set; }

        public virtual ICollection<NetTiendum> IdTienda { get; set; }
    }
}
