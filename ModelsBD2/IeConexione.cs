using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class IeConexione
    {
        public IeConexione()
        {
            IeCubos = new HashSet<IeCubo>();
        }

        public int IdConexion { get; set; }
        public string ServidorBd { get; set; } = null!;
        public string NombreBd { get; set; } = null!;
        public string? UsuarioBd { get; set; }
        public string? ContrasenyaBd { get; set; }

        public virtual ICollection<IeCubo> IeCubos { get; set; }
    }
}
