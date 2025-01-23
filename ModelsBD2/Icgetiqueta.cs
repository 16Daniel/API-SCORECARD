using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Icgetiqueta
    {
        public int Grupo { get; set; }
        public int Etiqueta { get; set; }
        public int Numelemento { get; set; }
        public short? Tipoelemento { get; set; }
        public short? Valor { get; set; }
        public short? Posx { get; set; }
        public short? Toptop { get; set; }
        public string? Fontname { get; set; }
        public int? Fontcolor { get; set; }
        public int? Fontsize { get; set; }
        public string? Fontbold { get; set; }
        public string? Fontitalic { get; set; }
        public string? Fontunderline { get; set; }
        public string? Fontstrikeout { get; set; }
        public short? Alignment { get; set; }
        public string? Campo { get; set; }
        public string? Mascara { get; set; }
        public short? Justificacion { get; set; }
        public int? Width { get; set; }
        public int? Height { get; set; }
        public int? Codtitulo { get; set; }
        public int Backcolor { get; set; }
        public short Linestyle { get; set; }
        public short Shapestyle { get; set; }
        public int Linecolor { get; set; }

        public virtual Icgnombresetiqueta Icgnombresetiqueta { get; set; } = null!;
    }
}
