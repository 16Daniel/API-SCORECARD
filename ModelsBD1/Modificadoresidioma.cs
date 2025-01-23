using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Modificadoresidioma
    {
        public int Codmodificador { get; set; }
        public int Codidioma { get; set; }
        public string? Descripcion { get; set; }
        public byte[]? Version { get; set; }

        public virtual Idioma CodidiomaNavigation { get; set; } = null!;
        public virtual Modificadorescab CodmodificadorNavigation { get; set; } = null!;
    }
}
