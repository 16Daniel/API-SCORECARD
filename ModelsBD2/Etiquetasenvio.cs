using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Etiquetasenvio
    {
        public Etiquetasenvio()
        {
            Etiquetasenviocabs = new HashSet<Etiquetasenviocab>();
        }

        public string Serie { get; set; } = null!;
        public int Numero { get; set; }
        public string N { get; set; } = null!;
        public int Numpartida { get; set; }
        public int? Numbultos { get; set; }
        public string? Etiqporbulto { get; set; }
        public double? Peso { get; set; }
        public string? Tipoportes { get; set; }
        public string? Empresaenvio { get; set; }
        public string? Direccion { get; set; }
        public string? Poblacion { get; set; }
        public string? Provincia { get; set; }
        public string? Codpostal { get; set; }
        public string? Observaciones { get; set; }
        public string? Impreso { get; set; }
        public double? Importecr { get; set; }
        public DateTime? Fechaenvio { get; set; }
        public string? Numexpedicion { get; set; }
        public string? Codembalaje { get; set; }
        public string? Codmanipulacion { get; set; }
        public string? Nombrecomercial { get; set; }
        public string? Direccion2 { get; set; }
        public string? Pais { get; set; }
        public string? Telefono { get; set; }
        public string? Fax { get; set; }
        public string? Email { get; set; }
        public string? Personacontacto { get; set; }
        public string? Poperacional { get; set; }
        public int? Codtransporte { get; set; }
        public string? Codpais { get; set; }
        public string? Observaciones2 { get; set; }
        public string? Observaciones3 { get; set; }

        public virtual Albventacab Albventacab { get; set; } = null!;
        public virtual ICollection<Etiquetasenviocab> Etiquetasenviocabs { get; set; }
    }
}
