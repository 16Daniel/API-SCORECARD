using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Balanza
    {
        public Balanza()
        {
            Balanzasentidades = new HashSet<Balanzasentidade>();
        }

        public int Id { get; set; }
        public int? Tipo { get; set; }
        public string? Nombre { get; set; }
        public string? Tcpip { get; set; }
        public int? Puertoorig { get; set; }
        public int? Puertodest { get; set; }
        public string? Export { get; set; }
        public string? Import { get; set; }
        public string? Activa { get; set; }
        public string? Esmaster { get; set; }
        public int? Seccion { get; set; }
        public int? Codarticulo { get; set; }
        public int Numterminal { get; set; }
        public int? Puertocom { get; set; }
        public int? Tipocom { get; set; }
        public int? Velocidad { get; set; }
        public string? Paridad { get; set; }
        public int? Bitsdatos { get; set; }
        public string? Codbarras { get; set; }

        public virtual ICollection<Balanzasentidade> Balanzasentidades { get; set; }
    }
}
