using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Contactosclientestemporale
    {
        public int Codcliente { get; set; }
        public string Cargo { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string? Telefono { get; set; }
        public string? EMail { get; set; }
        public int? Id { get; set; }
        public string? Dptoedi { get; set; }
        public bool? Facturacion { get; set; }
        public bool? Tesoreria { get; set; }
        public string? Mobil { get; set; }

        public virtual Clientestemporale CodclienteNavigation { get; set; } = null!;
    }
}
