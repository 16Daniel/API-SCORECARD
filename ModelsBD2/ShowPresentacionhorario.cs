using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class ShowPresentacionhorario
    {
        public int Idhorario { get; set; }
        public DateTime Hora { get; set; }
        public int? Idlunes { get; set; }
        public int? Idmartes { get; set; }
        public int? Idmiercoles { get; set; }
        public int? Idjueves { get; set; }
        public int? Idviernes { get; set; }
        public int? Idsabado { get; set; }
        public int? Iddomingo { get; set; }

        public virtual ShowPresentacione? IddomingoNavigation { get; set; }
        public virtual ShowHorario IdhorarioNavigation { get; set; } = null!;
        public virtual ShowPresentacione? IdjuevesNavigation { get; set; }
        public virtual ShowPresentacione? IdlunesNavigation { get; set; }
        public virtual ShowPresentacione? IdmartesNavigation { get; set; }
        public virtual ShowPresentacione? IdmiercolesNavigation { get; set; }
        public virtual ShowPresentacione? IdsabadoNavigation { get; set; }
        public virtual ShowPresentacione? IdviernesNavigation { get; set; }
    }
}
