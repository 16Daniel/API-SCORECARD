using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class RemHotelesFront
    {
        public int Idfront { get; set; }
        public int Idhotel { get; set; }
        public string? Seriereservas { get; set; }
        public string? Seriealbaranes { get; set; }
        public string? Seriefacturas { get; set; }
        public string? Serietiquets { get; set; }
        public string? Serieinvitaciones { get; set; }
        public bool? Actualizado { get; set; }
        public string? Serieabonos { get; set; }
        public bool? Nuevo { get; set; }
        public byte[] Version { get; set; } = null!;
        public string? Seriegastos { get; set; }
        public string? Serieabonostiquets { get; set; }

        public virtual RemFront IdfrontNavigation { get; set; } = null!;
    }
}
