using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class MotivosabonoIdioma
    {
        public int Idmotivoabono { get; set; }
        public int Codidioma { get; set; }
        public int? Posicion { get; set; }
        public string? Descripcion { get; set; }

        public virtual Motivosabono IdmotivoabonoNavigation { get; set; } = null!;
    }
}
