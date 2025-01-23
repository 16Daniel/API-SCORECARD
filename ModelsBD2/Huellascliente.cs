using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Huellascliente
    {
        public int Codcliente { get; set; }
        public byte[]? Huella { get; set; }
        public byte[]? Huella2 { get; set; }
        public byte[]? Huellax64 { get; set; }
        public byte[]? Huella2x64 { get; set; }
        public string? Huellatxt1 { get; set; }
        public string? Huellatxt2 { get; set; }

        public virtual Cliente CodclienteNavigation { get; set; } = null!;
    }
}
