using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class BiInforme
    {
        public BiInforme()
        {
            BiInformesUsuarios = new HashSet<BiInformesUsuario>();
        }

        public int Idinforme { get; set; }
        public string? Titulo { get; set; }
        public string? Nombrecubo { get; set; }

        public virtual ICollection<BiInformesUsuario> BiInformesUsuarios { get; set; }
    }
}
