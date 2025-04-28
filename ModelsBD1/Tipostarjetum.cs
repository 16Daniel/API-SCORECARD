using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Tipostarjetum
    {
        public Tipostarjetum()
        {
            Tarjeta = new HashSet<Tarjeta>();
            Tipostarjetacondiciones = new HashSet<Tipostarjetacondicione>();
            Tipostarjetacondicionesrtls = new HashSet<Tipostarjetacondicionesrtl>();
            Tipostarjetapromociones = new HashSet<Tipostarjetapromocione>();
            Codarticulos = new HashSet<Articulo1>();
            CodarticulosNavigation = new HashSet<Articulo1>();
        }

        public int Idtipotarjeta { get; set; }
        public string? Descripcion { get; set; }
        public string? Condicionesporfront { get; set; }
        public string? Promocionesporfront { get; set; }
        public string? Reiniciarxsesion { get; set; }
        public string? Noacumpuntosconsumiciones { get; set; }
        public byte[]? Version { get; set; }
        public string? Admitesaldo { get; set; }
        public string? Admitesobrecargo { get; set; }
        public int? Tipovalidez { get; set; }
        public int? Articulosaldo { get; set; }
        public bool? Esentrada { get; set; }
        public int? Articuloentrada { get; set; }
        public DateTime? Entradadesde { get; set; }
        public DateTime? Entradahasta { get; set; }
        public DateTime? Horaentrada { get; set; }
        public DateTime? Horasalida { get; set; }
        public int? Numentradasdia { get; set; }
        public bool? Identsalida { get; set; }
        public bool? Identhuella { get; set; }
        public bool? Acumularmenus { get; set; }
        public int? Numacumularmenus { get; set; }
        public string? Textoregalomenu { get; set; }
        public bool? Avisoidentificar { get; set; }
        public string? Textoavisoidentificar { get; set; }
        public string? Permitirrecargas { get; set; }
        public int? Idtarjetamin { get; set; }
        public int? Idtarjetamax { get; set; }

        public virtual ICollection<Tarjeta> Tarjeta { get; set; }
        public virtual ICollection<Tipostarjetacondicione> Tipostarjetacondiciones { get; set; }
        public virtual ICollection<Tipostarjetacondicionesrtl> Tipostarjetacondicionesrtls { get; set; }
        public virtual ICollection<Tipostarjetapromocione> Tipostarjetapromociones { get; set; }

        public virtual ICollection<Articulo1> Codarticulos { get; set; }
        public virtual ICollection<Articulo1> CodarticulosNavigation { get; set; }
    }
}
