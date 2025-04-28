using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Ventascashdroanticipo
    {
        public string Serie { get; set; } = null!;
        public int Numero { get; set; }
        public string N { get; set; } = null!;
        public string? Enlace { get; set; }
        public string OrigenT { get; set; } = null!;
        public string TipodocumentoT { get; set; } = null!;
        public string SerieT { get; set; } = null!;
        public int NumeroT { get; set; }
        public string NT { get; set; } = null!;
        public int PosicionT { get; set; }
        public bool Remoto { get; set; }
    }
}
