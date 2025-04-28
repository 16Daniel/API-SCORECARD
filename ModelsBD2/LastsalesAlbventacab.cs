using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class LastsalesAlbventacab
    {
        public LastsalesAlbventacab()
        {
            LastsalesAlbventalins = new HashSet<LastsalesAlbventalin>();
        }

        public string Numserie { get; set; } = null!;
        public int Numalbaran { get; set; }
        public string N { get; set; } = null!;
        public string? Esunprestamo { get; set; }
        public int? Codcliente { get; set; }
        public DateTime? Fecha { get; set; }
        public int? Codmoneda { get; set; }
        public string? Caja { get; set; }
        public string? Ivaincluido { get; set; }

        public virtual ICollection<LastsalesAlbventalin> LastsalesAlbventalins { get; set; }
    }
}
