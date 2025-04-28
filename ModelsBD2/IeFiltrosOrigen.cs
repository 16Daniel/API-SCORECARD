using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class IeFiltrosOrigen
    {
        public IeFiltrosOrigen()
        {
            IeValoresFiltrosOrigens = new HashSet<IeValoresFiltrosOrigen>();
        }

        public int IdCubo { get; set; }
        public int IdFiltroOrigen { get; set; }
        public int IdCampoRelacional { get; set; }
        public int Comparador { get; set; }

        public virtual IeCamposRelacionale IdCampoRelacionalNavigation { get; set; } = null!;
        public virtual IeCubo IdCuboNavigation { get; set; } = null!;
        public virtual ICollection<IeValoresFiltrosOrigen> IeValoresFiltrosOrigens { get; set; }
    }
}
