using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class NetTerminal
    {
        public NetTerminal()
        {
            NetIncidenciasTerminals = new HashSet<NetIncidenciasTerminal>();
            NetPeticionReenvios = new HashSet<NetPeticionReenvio>();
        }

        public Guid IdTerminal { get; set; }
        public int? IdTienda { get; set; }
        public string? NombreTerminal { get; set; }
        public string? Usuario { get; set; }
        public string? Password { get; set; }
        public Guid? IdCaja { get; set; }
        public DateTime? FechaInicializacion { get; set; }
        public DateTime? FechaDownload { get; set; }
        public DateTime? FechaUpload { get; set; }

        public virtual NetCaja? IdCajaNavigation { get; set; }
        public virtual NetTiendum? IdTiendaNavigation { get; set; }
        public virtual ICollection<NetIncidenciasTerminal> NetIncidenciasTerminals { get; set; }
        public virtual ICollection<NetPeticionReenvio> NetPeticionReenvios { get; set; }
    }
}
