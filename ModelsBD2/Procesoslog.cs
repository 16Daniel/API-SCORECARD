using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Procesoslog
    {
        public long Id { get; set; }
        public int? Idproceso { get; set; }
        public int? Tipo { get; set; }
        public DateTime? Fechaejecucion { get; set; }
        public DateTime? Horaejecucion { get; set; }
        public int? Estado { get; set; }
        public string? Ejecucionmsg { get; set; }
        public string? Ejecucionterminal { get; set; }
        public string? Enhilosecundario { get; set; }
        public int? Tipoejecutante { get; set; }
    }
}
