using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class ShowDiapositivaspresentacion
    {
        public int Idpresentacion { get; set; }
        public int Posicion { get; set; }
        public int? Iddiapositiva { get; set; }

        public virtual ShowDiapositiva? IddiapositivaNavigation { get; set; }
        public virtual ShowPresentacione IdpresentacionNavigation { get; set; } = null!;
    }
}
