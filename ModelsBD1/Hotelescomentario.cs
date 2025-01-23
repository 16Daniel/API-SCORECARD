using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Hotelescomentario
    {
        public int Idhotel { get; set; }
        public int Idcomentario { get; set; }
        public string Codidioma { get; set; } = null!;
        public string? Comentario { get; set; }
        public byte[] Version { get; set; } = null!;
    }
}
