using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Clientestarifascompra
    {
        public int Codcliente { get; set; }
        public int Codproveedor { get; set; }
        public int Idtarifac { get; set; }
        public bool? Compradirecta { get; set; }
        public byte[] Version { get; set; } = null!;

        public virtual Cliente CodclienteNavigation { get; set; } = null!;
        public virtual Tarifascompra Tarifascompra { get; set; } = null!;
    }
}
