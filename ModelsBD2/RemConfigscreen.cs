using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class RemConfigscreen
    {
        public int Idfront { get; set; }
        public short Pantalla { get; set; }
        public string Elemento { get; set; } = null!;
        public short? ITop { get; set; }
        public short? Height { get; set; }
        public short? Width { get; set; }
        public short? Filas { get; set; }
        public short? Columnas { get; set; }
        public short? Lineastexto { get; set; }
        public string? Visible { get; set; }
        public short? Comando { get; set; }
        public string? Tipo { get; set; }
        public short? Tamfuente { get; set; }
        public string? Nomfuente { get; set; }

        public virtual RemFront IdfrontNavigation { get; set; } = null!;
    }
}
