using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Icgnombresetiqueta
    {
        public Icgnombresetiqueta()
        {
            Icgetiqueta = new HashSet<Icgetiqueta>();
        }

        public int Grupo { get; set; }
        public int Diseny { get; set; }
        public string? Nombre { get; set; }
        public int? Codtitulo { get; set; }
        public byte[] Version { get; set; } = null!;

        public virtual ICollection<Icgetiqueta> Icgetiqueta { get; set; }
    }
}
