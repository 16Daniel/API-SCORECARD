using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Asunto
    {
        public Asunto()
        {
            Asuntosarticulos = new HashSet<Asuntosarticulo>();
            Asuntosbloqueos = new HashSet<Asuntosbloqueo>();
            Historicoasuntos = new HashSet<Historicoasunto>();
            Respuestasasuntoconfigurables = new HashSet<Respuestasasuntoconfigurable>();
            Servicios = new HashSet<Servicio>();
        }

        public string Serie { get; set; } = null!;
        public int Numero { get; set; }
        public int Creador { get; set; }
        public int? Codcliente { get; set; }
        public DateTime? Fecha { get; set; }
        public DateTime? Fechafinalizado { get; set; }
        public string? Asunto1 { get; set; }
        public int Tipoasunto { get; set; }
        public int? Codurgencia { get; set; }
        public string? Codlugar { get; set; }
        public string? Campobusqueda1 { get; set; }
        public string? Campobusqueda2 { get; set; }
        public string? Haytemaspendientes { get; set; }
        public int? Estado { get; set; }
        public string? Nombrearticulo { get; set; }
        public int? Codcondicion { get; set; }
        public int? Codsubcontrata { get; set; }
        public string? Avisarcliente { get; set; }
        public string? Nombrecontacto { get; set; }
        public int? Codenvio { get; set; }
        public string? Suasunto { get; set; }
        public int? Tipoavisosat { get; set; }
        public string? Pendfacturar { get; set; }
        public int? Codarticulo { get; set; }
        public string Talla { get; set; } = null!;
        public string Color { get; set; } = null!;
        public string? Tituloasunto { get; set; }
        public string? Finalizado { get; set; }
        public int? Codenviosubcontrata { get; set; }
        public DateTime? Fecha1 { get; set; }
        public DateTime? Fecha2 { get; set; }
        public DateTime? Fecha3 { get; set; }
        public int? Idhotel { get; set; }
        public byte[] Version { get; set; } = null!;
        public int Idcupoweb { get; set; }

        public virtual Tipoasunto TipoasuntoNavigation { get; set; } = null!;
        public virtual Asuntoscamposlibre? Asuntoscamposlibre { get; set; }
        public virtual Hreservasasunto? Hreservasasunto { get; set; }
        public virtual ICollection<Asuntosarticulo> Asuntosarticulos { get; set; }
        public virtual ICollection<Asuntosbloqueo> Asuntosbloqueos { get; set; }
        public virtual ICollection<Historicoasunto> Historicoasuntos { get; set; }
        public virtual ICollection<Respuestasasuntoconfigurable> Respuestasasuntoconfigurables { get; set; }
        public virtual ICollection<Servicio> Servicios { get; set; }
    }
}
