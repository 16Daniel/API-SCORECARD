using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class SemanasCtovtainv
    {
        public string Serie { get; set; } = null!;
        public int Semana { get; set; }
        public int Año { get; set; }
        public int Codarticulo { get; set; }
        public int Codmarca { get; set; }
        public string Referencia { get; set; } = null!;
        public double Stock { get; set; }
        public double Costo { get; set; }
        public double Importe { get; set; }
        public string Grupo { get; set; } = null!;
    }
}
