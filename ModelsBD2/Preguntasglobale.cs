using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Preguntasglobale
    {
        public int Codpregunta { get; set; }
        public string? Textopregunta { get; set; }
        public int? Tipo { get; set; }
        public string? Captioninforme { get; set; }
    }
}
