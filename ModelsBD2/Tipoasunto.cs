using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Tipoasunto
    {
        public Tipoasunto()
        {
            Asuntopreguntasconfigurables = new HashSet<Asuntopreguntasconfigurable>();
            Asuntos = new HashSet<Asunto>();
            Camposlibresportipoasuntos = new HashSet<Camposlibresportipoasunto>();
            Hcuposservicios = new HashSet<Hcuposservicio>();
            Predefinidoslins = new HashSet<Predefinidoslin>();
            Resultadosglobalesservicios = new HashSet<Resultadosglobalesservicio>();
            Codvendedors = new HashSet<Vendedore>();
        }

        public int Idtipoasunto { get; set; }
        public string? Descripcion { get; set; }
        public string? Camposvisibles { get; set; }
        public string? Camposobligatorios { get; set; }
        public int? Codurgencia { get; set; }
        public string? Codlugar { get; set; }
        public int? Codtiposat { get; set; }
        public int? Subcontratadopor { get; set; }
        public int? Codenviosubcontrata { get; set; }
        public int? Codcondicion { get; set; }
        public string? Nombrecb1 { get; set; }
        public string? Nombrecb2 { get; set; }
        public int? Codart { get; set; }
        public string Talla { get; set; } = null!;
        public string Color { get; set; } = null!;
        public string? Serie { get; set; }
        public int? Busqtipoasunto { get; set; }
        public string? Nombrefecha1 { get; set; }
        public string? Nombrefecha2 { get; set; }
        public string? Nombrefecha3 { get; set; }
        public bool? Verprimerodoc { get; set; }
        public bool? Fechaprimerservicio { get; set; }
        public bool? Copiarobsserv { get; set; }
        public bool? Verinfo1serv { get; set; }
        public bool? Showlista { get; set; }
        public int? Estadoini { get; set; }
        public string? Pestanyasvisibles { get; set; }
        public int? Idpestanyadefecto { get; set; }
        public bool? Actividadporcliente { get; set; }
        public bool? Seleccionablereserva { get; set; }
        public bool? Seriefacigual { get; set; }
        public byte[] Version { get; set; } = null!;
        public string? Seriefac { get; set; }
        public string? Serieabono { get; set; }
        public bool? Showeditor { get; set; }
        public bool Usarfechahora { get; set; }
        public bool? Emailsubcontrata { get; set; }
        public bool? Genresultados { get; set; }
        public bool? Concatservicios { get; set; }
        public bool Descatalogado { get; set; }
        public bool? Nocheckclientediahora { get; set; }
        public bool? Nocheckrecalcularprecioscliente { get; set; }

        public virtual ICollection<Asuntopreguntasconfigurable> Asuntopreguntasconfigurables { get; set; }
        public virtual ICollection<Asunto> Asuntos { get; set; }
        public virtual ICollection<Camposlibresportipoasunto> Camposlibresportipoasuntos { get; set; }
        public virtual ICollection<Hcuposservicio> Hcuposservicios { get; set; }
        public virtual ICollection<Predefinidoslin> Predefinidoslins { get; set; }
        public virtual ICollection<Resultadosglobalesservicio> Resultadosglobalesservicios { get; set; }

        public virtual ICollection<Vendedore> Codvendedors { get; set; }
    }
}
