using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Mensaje
    {
        public int Codigo { get; set; }
        public string Emisor { get; set; } = null!;
        public string Receptor { get; set; } = null!;
        public DateTime Fechaini { get; set; }
        public DateTime Fechafin { get; set; }
        public DateTime Fechamodificado { get; set; }
        public string? Mensaje1 { get; set; }
    }
}
