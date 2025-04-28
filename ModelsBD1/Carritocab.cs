using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Carritocab
    {
        public Carritocab()
        {
            Carritolins = new HashSet<Carritolin>();
        }

        public string Idcarrito { get; set; } = null!;
        public int? Codcliente { get; set; }
        public int? Codmoneda { get; set; }
        public int? Codtarifa { get; set; }
        public string? Ivaincluido { get; set; }
        public DateTime? Fechaentrega { get; set; }
        public int? Codenvio { get; set; }
        public string? Codalmacen { get; set; }

        public virtual ICollection<Carritolin> Carritolins { get; set; }
    }
}
