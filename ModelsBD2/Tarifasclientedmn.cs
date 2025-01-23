using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Tarifasclientedmn
    {
        public int Codcliente { get; set; }
        public int Idtarifav { get; set; }
        public string? Descripcion { get; set; }
        public int? Posicion { get; set; }
        public double? Dto { get; set; }
        public int? Codproveedor { get; set; }
        public string? Codexterno { get; set; }
        public byte[]? Version { get; set; }

        public virtual Cliente CodclienteNavigation { get; set; } = null!;
        public virtual Tarifasventum IdtarifavNavigation { get; set; } = null!;
    }
}
