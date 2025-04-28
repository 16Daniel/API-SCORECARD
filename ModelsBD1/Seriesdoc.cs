using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Seriesdoc
    {
        public int Tipodoc { get; set; }
        public string Serie { get; set; } = null!;
        public int? Posicion { get; set; }
        public int? Contadorb { get; set; }
        public int? Contadorn { get; set; }

        public virtual Series SerieNavigation { get; set; } = null!;
        public virtual Tiposdoc TipodocNavigation { get; set; } = null!;
    }
}
