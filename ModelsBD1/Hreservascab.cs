using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Hreservascab
    {
        public Hreservascab()
        {
            Hreservas = new HashSet<Hreserva>();
            Hreservasasuntos = new HashSet<Hreservasasunto>();
            Hreservasbloqueos = new HashSet<Hreservasbloqueo>();
            Hreservasdocumentos = new HashSet<Hreservasdocumento>();
            Hreservasestadosautos = new HashSet<Hreservasestadosauto>();
        }

        public int Idhotel { get; set; }
        public string Serie { get; set; } = null!;
        public int Idreserva { get; set; }
        public string? Sureserva { get; set; }
        public DateTime? Fecha { get; set; }
        public int? Codintermediario { get; set; }
        public int? Idcupo { get; set; }
        public int? Tipo { get; set; }
        public int? Estadoreserva { get; set; }
        public DateTime? Modificado { get; set; }
        public int? Usermodificado { get; set; }
        public int? Idtarifa { get; set; }
        public int? Codempresa { get; set; }
        public string? Ocupante { get; set; }
        public string? Contacto { get; set; }
        public int? Codempleado { get; set; }
        public int? Numversion { get; set; }
        public string? Observaciones { get; set; }
        public DateTime? Fechaentrada { get; set; }
        public DateTime? Fechasalida { get; set; }
        public string? Regimen { get; set; }
        public int? Facturara { get; set; }
        public int? Codmoneda { get; set; }
        public double? Factormoneda { get; set; }
        public string? Pendientedescarga { get; set; }
        public string? Nifocupante { get; set; }
        public int? Extrasa { get; set; }
        public byte Pendientedescarga2 { get; set; }
        public DateTime? Fechavto { get; set; }
        public int? Estadovto { get; set; }
        public int Idcupoweb { get; set; }
        public int? Mailcheckinenviado { get; set; }
        public string? Telefono { get; set; }
        public string? Email { get; set; }

        public virtual Reservacamposlibre? Reservacamposlibre { get; set; }
        public virtual ICollection<Hreserva> Hreservas { get; set; }
        public virtual ICollection<Hreservasasunto> Hreservasasuntos { get; set; }
        public virtual ICollection<Hreservasbloqueo> Hreservasbloqueos { get; set; }
        public virtual ICollection<Hreservasdocumento> Hreservasdocumentos { get; set; }
        public virtual ICollection<Hreservasestadosauto> Hreservasestadosautos { get; set; }
    }
}
