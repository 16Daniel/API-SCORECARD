using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class BiPermisosUsuario
    {
        public int Idusuario { get; set; }
        public string? Permisos { get; set; }
        public int? Idinformedefecto { get; set; }

        public virtual IeInforme? IdinformedefectoNavigation { get; set; }
    }
}
