using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Estadistica
    {
        public Estadistica()
        {
            EstadisticaUsuarios = new HashSet<EstadisticaUsuario>();
        }

        public int Tipo { get; set; }
        public int Idinforme { get; set; }
        public string? Descripcion { get; set; }
        public string? Nombre { get; set; }
        public int Grupo { get; set; }
        public int Subgrupo { get; set; }

        public virtual EstadisticaGrupo GrupoNavigation { get; set; } = null!;
        public virtual Informe IdinformeNavigation { get; set; } = null!;
        public virtual ICollection<EstadisticaUsuario> EstadisticaUsuarios { get; set; }
    }
}
