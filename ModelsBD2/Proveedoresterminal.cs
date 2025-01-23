using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Proveedoresterminal
    {
        public int Idterminal { get; set; }
        public int Id { get; set; }
        public int? Visibilidad { get; set; }

        public virtual Terminale IdterminalNavigation { get; set; } = null!;
    }
}
