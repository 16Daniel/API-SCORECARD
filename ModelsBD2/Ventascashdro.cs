using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Ventascashdro
    {
        public string Serie { get; set; } = null!;
        public int Numero { get; set; }
        public string N { get; set; } = null!;
        public int Tipodoc { get; set; }
        public int Idtipodoc { get; set; }
        public bool Estado { get; set; }
        public DateTime? Fecha { get; set; }
        public bool Imprimir { get; set; }
        public int? Tipodocimp { get; set; }
        public int? Coddiseny { get; set; }
        public string? Impresora { get; set; }
        public string? Enlace { get; set; }
        public bool? Ticket { get; set; }
        public bool? Tarjeta { get; set; }
    }
}
