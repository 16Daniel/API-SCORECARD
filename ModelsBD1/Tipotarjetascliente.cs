using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Tipotarjetascliente
    {
        public Tipotarjetascliente()
        {
            Tiporegalostarjeta = new HashSet<Tiporegalostarjetum>();
        }

        public int Id { get; set; }
        public string? Descripcion { get; set; }
        public string? Reiniciarxsesion { get; set; }
        public int? Tarifaconsumiciones { get; set; }
        public double? Dtoconsumiciones { get; set; }
        public string? Noacumpuntosconsumiciones { get; set; }
        public int? Tarifapuntos { get; set; }
        public int? Numconsumiciones { get; set; }
        public int? Numconsumicionesl { get; set; }
        public int? Numconsumicionesm { get; set; }
        public int? Numconsumicionesx { get; set; }
        public int? Numconsumicionesj { get; set; }
        public int? Numconsumicionesv { get; set; }
        public int? Numconsumicioness { get; set; }
        public int? Numconsumicionesd { get; set; }

        public virtual ICollection<Tiporegalostarjetum> Tiporegalostarjeta { get; set; }
    }
}
