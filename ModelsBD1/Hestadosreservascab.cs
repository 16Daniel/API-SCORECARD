using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Hestadosreservascab
    {
        public int Codigo { get; set; }
        public string Descripcion { get; set; } = null!;
        public bool? Booking { get; set; }
        public bool? Afectacupo { get; set; }
        public bool? Afectacocina { get; set; }
        public int? Colorfondo { get; set; }
        public int? Colortexto { get; set; }
        public byte[]? Version { get; set; }
        public bool? Fechavto { get; set; }
        public int? Estadovto { get; set; }
        public int? Dias { get; set; }
        public bool? Aplicarcargosdtos { get; set; }
        public bool? Bloquearrecalculo { get; set; }
        public bool? Cambiohabocupada { get; set; }
        public bool? Cambiohabpreasignada { get; set; }
    }
}
