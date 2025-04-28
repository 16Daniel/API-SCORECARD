using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class IeInforme
    {
        public IeInforme()
        {
            BiPermisosUsuarios = new HashSet<BiPermisosUsuario>();
            IeControlesInformes = new HashSet<IeControlesInforme>();
            IeUsuariosInformes = new HashSet<IeUsuariosInforme>();
        }

        public int IdInforme { get; set; }
        public string? Titulo { get; set; }
        public int IdGrupo { get; set; }

        public virtual IeGrupo IdGrupoNavigation { get; set; } = null!;
        public virtual ICollection<BiPermisosUsuario> BiPermisosUsuarios { get; set; }
        public virtual ICollection<IeControlesInforme> IeControlesInformes { get; set; }
        public virtual ICollection<IeUsuariosInforme> IeUsuariosInformes { get; set; }
    }
}
