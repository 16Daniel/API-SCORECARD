using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Plantillasusuario
    {
        public string Tituloplantilla { get; set; } = null!;
        public string Tipoplantilla { get; set; } = null!;
        public string Tipocolumna { get; set; } = null!;
        public string? Titulocolumna { get; set; }
        public int? Posicion { get; set; }
        public int? Ancho { get; set; }
        public string? Activa { get; set; }
        public string? Color { get; set; }
        public int? Multiple { get; set; }
        public int? Decimales { get; set; }
        public byte[] Version { get; set; } = null!;
        public int? Programa { get; set; }
    }
}
