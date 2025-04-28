using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Tarjetascliente
    {
        public Tarjetascliente()
        {
            Regalospendientestarjeta = new HashSet<Regalospendientestarjetum>();
        }

        public int Codcliente { get; set; }
        public int Idtarjeta { get; set; }
        public int? Posicion { get; set; }
        public int? Idtipotarjeta { get; set; }
        public string? Descripcion { get; set; }
        public DateTime? Caducidad { get; set; }
        public int? Consrealizadas { get; set; }
        public int? Puntosacumulados { get; set; }
        public double? Consacumuladas { get; set; }
        public double? Importeacumulado { get; set; }
        public double? Ticketsacumulados { get; set; }
        public string? Valida { get; set; }
        public DateTime? Fecharecalc { get; set; }

        public virtual Cliente CodclienteNavigation { get; set; } = null!;
        public virtual ICollection<Regalospendientestarjetum> Regalospendientestarjeta { get; set; }
    }
}
