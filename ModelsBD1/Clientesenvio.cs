using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Clientesenvio
    {
        public int Codcliente { get; set; }
        public int Codenvio { get; set; }
        public string? Nombrecomercial { get; set; }
        public string? Direccion1 { get; set; }
        public string? Direccion2 { get; set; }
        public string? Codpostal { get; set; }
        public string? Poblacion { get; set; }
        public string? Provincia { get; set; }
        public string? Pais { get; set; }
        public string? Telefono { get; set; }
        public string? Fax { get; set; }
        public string? Email { get; set; }
        public string? Personacontacto { get; set; }
        public int? Codtransporte { get; set; }
        public string? Tipoportes { get; set; }
        public double? Cantportespag { get; set; }
        public string? Poperacional { get; set; }
        public string? Defecto { get; set; }
        public double? Kms { get; set; }
        public string? Codpais { get; set; }
        public string? Observaciones { get; set; }

        public virtual Cliente CodclienteNavigation { get; set; } = null!;
    }
}
