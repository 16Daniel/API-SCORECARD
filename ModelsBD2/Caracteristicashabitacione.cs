using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Caracteristicashabitacione
    {
        public int Idcaracteristica { get; set; }
        public string? Texto { get; set; }
        public string Descripcion { get; set; } = null!;
        public int? Colorfondo { get; set; }
        public int? Colortexto { get; set; }
        public bool Descatalogado { get; set; }
        public byte[]? Imagen { get; set; }
    }
}
