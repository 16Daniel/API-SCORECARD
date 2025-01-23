using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class CmrcFoto
    {
        public int Codigo { get; set; }
        public byte[]? Foto { get; set; }
        public byte[] Version { get; set; } = null!;
    }
}
