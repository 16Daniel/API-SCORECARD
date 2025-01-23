using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class IeGruposMedida
    {
        public IeGruposMedida()
        {
            Ids = new HashSet<IeMetrica>();
        }

        public int IdGrupoMedida { get; set; }
        public int IdCubo { get; set; }
        public string Name { get; set; } = null!;
        public string? IdTitulo { get; set; }
        public int NumRegistros { get; set; }

        public virtual IeCubo IdCuboNavigation { get; set; } = null!;

        public virtual ICollection<IeMetrica> Ids { get; set; }
    }
}
