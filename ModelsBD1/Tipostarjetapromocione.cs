using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Tipostarjetapromocione
    {
        public Tipostarjetapromocione()
        {
            Tipostarjetapromocioneslinrtls = new HashSet<Tipostarjetapromocioneslinrtl>();
            Tipostarjetapromocioneslins = new HashSet<Tipostarjetapromocioneslin>();
        }

        public int Idtipotarjeta { get; set; }
        public int Idfront { get; set; }
        public int? Idtarifapuntos { get; set; }
        public int? Tipopromocion { get; set; }
        public double? Valorext1 { get; set; }
        public double? Valorext2 { get; set; }
        public int? CodartAlta { get; set; }
        public string? TallaAlta { get; set; }
        public string? ColorAlta { get; set; }
        public int? CodartRenovacion { get; set; }
        public string? TallaRenovacion { get; set; }
        public string? ColorRenovacion { get; set; }
        public int? Diasvalidez { get; set; }
        public int? Diasrenovacion { get; set; }
        public int? Diasalta { get; set; }
        public string? Admiteporcensaldo { get; set; }
        public double? Valorporcsaldo { get; set; }
        public string? Conivapsaldo { get; set; }

        public virtual Tipostarjetum IdtipotarjetaNavigation { get; set; } = null!;
        public virtual ICollection<Tipostarjetapromocioneslinrtl> Tipostarjetapromocioneslinrtls { get; set; }
        public virtual ICollection<Tipostarjetapromocioneslin> Tipostarjetapromocioneslins { get; set; }
    }
}
