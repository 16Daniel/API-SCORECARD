using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class HioposEstadFiltrosLibre
    {
        public int Id { get; set; }
        public int Posicion { get; set; }
        public int Iddimension { get; set; }
        public string Nombrecampo { get; set; } = null!;
        public string Valor { get; set; } = null!;
        public string? Captioncampo { get; set; }
        public int Tipocampo { get; set; }
        public int Operador { get; set; }

        public virtual HioposEstad IdNavigation { get; set; } = null!;
    }
}
