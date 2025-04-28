using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class EstadisticaSubgrupo
    {
        public int Idgrupo { get; set; }
        public int Idsubgrupo { get; set; }
        public string? Descripcion { get; set; }

        public virtual EstadisticaGrupo IdgrupoNavigation { get; set; } = null!;
    }
}
