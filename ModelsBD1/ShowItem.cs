using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class ShowItem
    {
        public int Iditem { get; set; }
        public int Iddiapositiva { get; set; }
        public int? Tipo { get; set; }
        public int? Posx { get; set; }
        public int? Posy { get; set; }
        public short? Ancho { get; set; }
        public short? Alto { get; set; }
        public short? Transparencia { get; set; }
        public short? Zorder { get; set; }
        public int? Idrecurso { get; set; }
        public string? Texto { get; set; }
        public string? Fontname { get; set; }
        public int? Fontsize { get; set; }
        public bool? Fontbold { get; set; }
        public bool? Fontitalic { get; set; }
        public int? Fontcolor { get; set; }
        public double? Escalax { get; set; }
        public double? Escalay { get; set; }
        public int? Angulo { get; set; }
        public int? Colorfondo { get; set; }
        public bool? Transparente { get; set; }
        public int? Posxin { get; set; }
        public int? Posyin { get; set; }
        public bool? Contorno { get; set; }

        public virtual ShowDiapositiva IddiapositivaNavigation { get; set; } = null!;
        public virtual ShowRecurso? IdrecursoNavigation { get; set; }
    }
}
