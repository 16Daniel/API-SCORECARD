using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class IeValoresFiltrosCuboSb
    {
        public int IdScoreboard { get; set; }
        public int IdGraficaSb { get; set; }
        public int IdFiltroCuboSb { get; set; }
        public int IdValorFiltroCuboSb { get; set; }
        public int IdValorCompuesto { get; set; }
        public int IdNivel { get; set; }
        public string Valor { get; set; } = null!;

        public virtual IeFiltrosCuboSb Id { get; set; } = null!;
    }
}
