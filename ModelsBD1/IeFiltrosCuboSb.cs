using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class IeFiltrosCuboSb
    {
        public IeFiltrosCuboSb()
        {
            IeValoresFiltrosCuboSbs = new HashSet<IeValoresFiltrosCuboSb>();
        }

        public int IdScoreboard { get; set; }
        public int IdGraficaSb { get; set; }
        public int IdFiltroCuboSb { get; set; }
        public int IdDimension { get; set; }
        public int? IdJerarquia { get; set; }
        public int? IdAtributo { get; set; }
        public int Comparador { get; set; }

        public virtual IeControlesInforme Id { get; set; } = null!;
        public virtual ICollection<IeValoresFiltrosCuboSb> IeValoresFiltrosCuboSbs { get; set; }
    }
}
