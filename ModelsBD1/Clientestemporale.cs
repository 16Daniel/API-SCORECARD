using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Clientestemporale
    {
        public int Codcliente { get; set; }
        public string? Cif { get; set; }
        public string? Alias { get; set; }
        public string? Nombrecliente { get; set; }
        public string? Nombrecomercial { get; set; }
        public string? Direccion1 { get; set; }
        public string? Direccion2 { get; set; }
        public string? Codpostal { get; set; }
        public string? Poblacion { get; set; }
        public string? Provincia { get; set; }
        public string? Pais { get; set; }
        public string? Codpais { get; set; }
        public string? Telefono1 { get; set; }
        public string? Telefono2 { get; set; }
        public string? Fax { get; set; }
        public string? EMail { get; set; }
        public string? Personacontacto { get; set; }
        public string? Nif20 { get; set; }
        public string? Crearcomovario { get; set; }
        public string? Procedencia { get; set; }
        public int? Codigoprocedencia { get; set; }
        public string? Descatalogado { get; set; }
        public string? Observaciones { get; set; }
        public string? Mobil { get; set; }
        public string? Recargo { get; set; }
        public string? Facturarsinimpuestos { get; set; }
        public int? Facturarconimpuesto { get; set; }

        public virtual Clientestemporalescamposlibre? Clientestemporalescamposlibre { get; set; }
    }
}
