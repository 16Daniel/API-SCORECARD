using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Lineascomunicacionlog
    {
        public int Idfront { get; set; }
        public string Tipo { get; set; } = null!;
        public DateTime Fechahoraini { get; set; }
        public int Id { get; set; }
        public DateTime? Fecha { get; set; }
        public string? Todo { get; set; }
        public string? Facturar { get; set; }
        public string? Ultimportacion { get; set; }
        public int Caja { get; set; }
        public int Zini { get; set; }
        public int Zfin { get; set; }

        public virtual Comunicacionlog Comunicacionlog { get; set; } = null!;
    }
}
