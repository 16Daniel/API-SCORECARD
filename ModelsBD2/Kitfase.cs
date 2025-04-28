using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Kitfase
    {
        public int Codarticulo { get; set; }
        public int Numfase { get; set; }
        public string? Descripcion { get; set; }
        public int? Numerosserie { get; set; }
        public bool? Enbloque { get; set; }
        public byte[]? Imagen { get; set; }
    }
}
