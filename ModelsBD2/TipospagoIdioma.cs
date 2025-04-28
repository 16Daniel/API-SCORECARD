using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class TipospagoIdioma
    {
        public string Codtipopago { get; set; } = null!;
        public int Codidioma { get; set; }
        public int? Posicion { get; set; }
        public string? Descripcion { get; set; }

        public virtual Tipospago CodtipopagoNavigation { get; set; } = null!;
    }
}
