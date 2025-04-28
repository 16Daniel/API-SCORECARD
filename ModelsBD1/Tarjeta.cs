using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Tarjeta
    {
        public Tarjeta()
        {
            Promocionesconseguida = new HashSet<Promocionesconseguida>();
            Tarjetascontcondiciones = new HashSet<Tarjetascontcondicione>();
            Tarjetascontmenus = new HashSet<Tarjetascontmenu>();
            Tarjetascontpromociones = new HashSet<Tarjetascontpromocione>();
        }

        public int Idtarjeta { get; set; }
        public int? Codcliente { get; set; }
        public int? Posicion { get; set; }
        public int? Idtipotarjeta { get; set; }
        public string? Descripcion { get; set; }
        public DateTime? Caducidad { get; set; }
        public string? Valida { get; set; }
        public double? Saldotarjeta { get; set; }
        public string? Entregada { get; set; }
        public string? Observaciones { get; set; }
        public string? Alias { get; set; }

        public virtual Tipostarjetum? IdtipotarjetaNavigation { get; set; }
        public virtual ICollection<Promocionesconseguida> Promocionesconseguida { get; set; }
        public virtual ICollection<Tarjetascontcondicione> Tarjetascontcondiciones { get; set; }
        public virtual ICollection<Tarjetascontmenu> Tarjetascontmenus { get; set; }
        public virtual ICollection<Tarjetascontpromocione> Tarjetascontpromociones { get; set; }
    }
}
