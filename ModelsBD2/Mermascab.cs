using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Mermascab
    {
        public Mermascab()
        {
            Mermaslins = new HashSet<Mermaslin>();
        }

        public int Idint { get; set; }
        public string? Serie { get; set; }
        public int? Numdoc { get; set; }
        public string? Codalmacen { get; set; }
        public DateTime? Fecha { get; set; }
        public DateTime? Hora { get; set; }
        public int? CodvalPvp { get; set; }
        public int? Codcomentario { get; set; }
        public string? Observaciones { get; set; }
        public int? Codempleado { get; set; }

        public virtual Almacen? CodalmacenNavigation { get; set; }
        public virtual ICollection<Mermaslin> Mermaslins { get; set; }
    }
}
