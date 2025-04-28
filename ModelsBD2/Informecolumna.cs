using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Informecolumna
    {
        public int Idinforme { get; set; }
        public int Posicion { get; set; }
        public string? Caption { get; set; }
        public string? Nombrecampo { get; set; }
        public string? Orden { get; set; }
        public int? Agrupado { get; set; }
        public string? Sumarizado { get; set; }
        public string? Visible { get; set; }
        public string? Mascara { get; set; }
        public int? Ancho { get; set; }
        public int? Posvisible { get; set; }
        public int? Rowindex { get; set; }

        public virtual Informe IdinformeNavigation { get; set; } = null!;
    }
}
