using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Departamentoidioma
    {
        public int Numdpto { get; set; }
        public int Numseccion { get; set; }
        public int Numfamilia { get; set; }
        public int Numsubfamilia { get; set; }
        public int Codidioma { get; set; }
        public string? Descripcion { get; set; }
        public byte[]? Version { get; set; }

        public virtual Idioma CodidiomaNavigation { get; set; } = null!;
        public virtual Departamento NumdptoNavigation { get; set; } = null!;
    }
}
