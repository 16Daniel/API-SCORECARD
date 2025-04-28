using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class ComDispositivo
    {
        public ComDispositivo()
        {
            ComTramas = new HashSet<ComTrama>();
        }

        public int Iddispositivo { get; set; }
        public string? Nombredispositivo { get; set; }
        public string? Listacodigos1 { get; set; }
        public string? Listacodigos2 { get; set; }
        public string? Listacodigos3 { get; set; }
        public int? Tipows { get; set; }
        public string? Keyws { get; set; }
        public string? Urlws { get; set; }

        public virtual ICollection<ComTrama> ComTramas { get; set; }
    }
}
