using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Tiposdoc
    {
        public Tiposdoc()
        {
            Docwords = new HashSet<Docword>();
            Estadostipodocs = new HashSet<Estadostipodoc>();
            Seriesdocs = new HashSet<Seriesdoc>();
            Tiposdocusuarios = new HashSet<Tiposdocusuario>();
        }

        public int Tipodoc { get; set; }
        public string? Descripcion { get; set; }
        public string? Plantilla { get; set; }
        public string? Signopositivo { get; set; }
        public string? Stock { get; set; }
        public string? Contabilidad { get; set; }
        public string? Modificable { get; set; }
        public int Tipodocumento { get; set; }
        public int Clasedocumento { get; set; }
        public string? Dependiente { get; set; }
        public string? Asociarcliente { get; set; }
        public string? Estiquet { get; set; }
        public string? Descmenu { get; set; }
        public string? Plantillaiva { get; set; }
        public string? Plantillarecepcion { get; set; }
        public string? Sufijo { get; set; }
        public string? Devolucion { get; set; }
        public string? Cerrado { get; set; }
        public string? Calcsinimpuestos { get; set; }
        public string? Notacargo { get; set; }
        public int? Numlineas { get; set; }
        public int? Iddissenycamposlibres { get; set; }
        public string? Positivono0 { get; set; }
        public string? Negativono0 { get; set; }
        public string? Tiporeginv { get; set; }

        public virtual Docwordconfig? Docwordconfig { get; set; }
        public virtual ICollection<Docword> Docwords { get; set; }
        public virtual ICollection<Estadostipodoc> Estadostipodocs { get; set; }
        public virtual ICollection<Seriesdoc> Seriesdocs { get; set; }
        public virtual ICollection<Tiposdocusuario> Tiposdocusuarios { get; set; }
    }
}
