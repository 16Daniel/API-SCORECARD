using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Dptovendedore
    {
        public Dptovendedore()
        {
            Codvendedors = new HashSet<Vendedore>();
        }

        public int Coddpto { get; set; }
        public string Descripcion { get; set; } = null!;
        public int? Idtipoasunto { get; set; }
        public byte[] Version { get; set; } = null!;
        public int? Intervalo { get; set; }
        public int? Altura { get; set; }
        public int? Dias { get; set; }

        public virtual ICollection<Vendedore> Codvendedors { get; set; }
    }
}
