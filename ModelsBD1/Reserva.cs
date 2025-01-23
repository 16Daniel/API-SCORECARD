using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Reserva
    {
        public Reserva()
        {
            Ocupantesreservas = new HashSet<Ocupantesreserva>();
            Reservascuposusados = new HashSet<Reservascuposusado>();
            Reservasdocs = new HashSet<Reservasdoc>();
            Reservasestados = new HashSet<Reservasestado>();
            Reservaslins = new HashSet<Reservaslin>();
        }

        public string Serie { get; set; } = null!;
        public int Idreserva { get; set; }
        public int Idlinea { get; set; }
        public string? Sureserva { get; set; }
        public DateTime? Fecha { get; set; }
        public DateTime? Fechaentrada { get; set; }
        public DateTime? Fechasalida { get; set; }
        public int? Tipohabitacion { get; set; }
        public int? Codclientefijos { get; set; }
        public int? Codclienteextras { get; set; }
        public int? Planta { get; set; }
        public int? Habitacion { get; set; }
        public int? Codformapago { get; set; }
        public string? Tarjeta { get; set; }
        public string? Observaciones { get; set; }
        public int? Estado { get; set; }
        public int? Idtarifa { get; set; }
        public string? Facturadaagencia { get; set; }
        public string? Preasignada { get; set; }
        public int? Codintermediario { get; set; }
        public int? Pagador { get; set; }
        public int? Idcupo { get; set; }
        public DateTime? Fechamodificado { get; set; }
        public int? Exportada { get; set; }
        public int? Tipo { get; set; }
        public int? Serventrada { get; set; }
        public int? Servsalida { get; set; }
        public DateTime? Horaentrada { get; set; }
        public DateTime? Horasalida { get; set; }

        public virtual ICollection<Ocupantesreserva> Ocupantesreservas { get; set; }
        public virtual ICollection<Reservascuposusado> Reservascuposusados { get; set; }
        public virtual ICollection<Reservasdoc> Reservasdocs { get; set; }
        public virtual ICollection<Reservasestado> Reservasestados { get; set; }
        public virtual ICollection<Reservaslin> Reservaslins { get; set; }
    }
}
