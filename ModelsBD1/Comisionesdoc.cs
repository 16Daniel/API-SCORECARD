using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Comisionesdoc
    {
        public int Contador { get; set; }
        public int Idcalculo { get; set; }
        public int Codvendedor { get; set; }
        public int Codlinea { get; set; }
        public string Serie { get; set; } = null!;
        public int Numero { get; set; }
        public string N { get; set; } = null!;
        public int? Tipodocumento { get; set; }
        public double? Importedoc { get; set; }
        public double? Comision { get; set; }
        public string? Seriefactura { get; set; }
        public int? Numerofactura { get; set; }
        public string? Nfactura { get; set; }

        public virtual Histocomisionescab Histocomisionescab { get; set; } = null!;
    }
}
