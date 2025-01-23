using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Planta
    {
        public Planta()
        {
            Confighabitaciones = new HashSet<Confighabitacione>();
        }

        public int Idhotel { get; set; }
        public short Planta1 { get; set; }
        public string? Nombre { get; set; }
        public byte[]? Version { get; set; }
        public string? Codalmacen { get; set; }
        public int? Codvendedor { get; set; }

        public virtual ICollection<Confighabitacione> Confighabitaciones { get; set; }
    }
}
