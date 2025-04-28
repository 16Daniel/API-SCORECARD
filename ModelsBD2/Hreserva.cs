using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Hreserva
    {
        public Hreserva()
        {
            Hocupantesreservas = new HashSet<Hocupantesreserva>();
            Hreservascorreccionesproduccions = new HashSet<Hreservascorreccionesproduccion>();
            Hreservaslins = new HashSet<Hreservaslin>();
        }

        public int Idhotel { get; set; }
        public string Serie { get; set; } = null!;
        public int Idreserva { get; set; }
        public int Idlinea { get; set; }
        public DateTime? Fechaentrada { get; set; }
        public DateTime? Fechasalida { get; set; }
        public int? Tipohabitacion { get; set; }
        public int? Codclientefijos { get; set; }
        public int? Codclienteextras { get; set; }
        public int? Planta { get; set; }
        public int? Habitacion { get; set; }
        public string? Codformapago { get; set; }
        public string? Observaciones { get; set; }
        public int? Estado { get; set; }
        public int? Idtarifa { get; set; }
        public string? Facturadaagencia { get; set; }
        public string? Preasignada { get; set; }
        public int? Pagador { get; set; }
        public DateTime? Fechamodificado { get; set; }
        public int? Exportada { get; set; }
        public int? Serventrada { get; set; }
        public int? Servsalida { get; set; }
        public DateTime? Horaentrada { get; set; }
        public DateTime? Horasalida { get; set; }
        public string? Terminal { get; set; }
        public DateTime? Ultimamodificacion { get; set; }
        public int? Ultvendedormodificacion { get; set; }
        public int? Pax { get; set; }
        public int? Paxnen { get; set; }
        public int? Paxbebe { get; set; }
        public int? Codregimen { get; set; }
        public string? Regimen { get; set; }
        public bool? Aplicadosuplemento { get; set; }
        public int? Idhotelfac { get; set; }
        public string? Seriefac { get; set; }
        public int? Idreservafac { get; set; }
        public int? Idlineafac { get; set; }
        public bool? Permextras { get; set; }
        public string? Cambiohabitacion { get; set; }
        public int? Codvendedor { get; set; }

        public virtual Hreservascab Hreservascab { get; set; } = null!;
        public virtual Hreservascentralitum? Hreservascentralitum { get; set; }
        public virtual ICollection<Hocupantesreserva> Hocupantesreservas { get; set; }
        public virtual ICollection<Hreservascorreccionesproduccion> Hreservascorreccionesproduccions { get; set; }
        public virtual ICollection<Hreservaslin> Hreservaslins { get; set; }
    }
}
