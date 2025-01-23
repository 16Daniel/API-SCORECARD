using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Contrato
    {
        public int Codcontrato { get; set; }
        public string Descripcion { get; set; } = null!;
        public byte[]? Version { get; set; }
    }
}
