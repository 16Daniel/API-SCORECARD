using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Predefinidoslin
    {
        public int Codlin { get; set; }
        public int Idtipoasunto { get; set; }
        public int? Orden { get; set; }
        public string? Defecto { get; set; }
        public int? Codservicio { get; set; }
        public int? Codempleado { get; set; }
        public int? Codconcepto { get; set; }
        public string Talla { get; set; } = null!;
        public string Color { get; set; } = null!;
        public int? Modofact { get; set; }
        public int? Tipodoc { get; set; }
        public int? Duracionpredefinida { get; set; }
        public int? Idpestanyadefecto { get; set; }
        public bool? Horafijada { get; set; }
        public int? Pax { get; set; }
        public int? Codrecurso { get; set; }
        public int? DisenyoCl { get; set; }
        public int? Cadaxpax { get; set; }

        public virtual Tipoasunto IdtipoasuntoNavigation { get; set; } = null!;
    }
}
