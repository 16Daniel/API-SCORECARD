using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class ComOperacione
    {
        public ComOperacione()
        {
            ComTramas = new HashSet<ComTrama>();
        }

        public int Idoperacion { get; set; }
        public string? Nombreoperacion { get; set; }
        public string? Inputoutput { get; set; }

        public virtual ICollection<ComTrama> ComTramas { get; set; }
    }
}
