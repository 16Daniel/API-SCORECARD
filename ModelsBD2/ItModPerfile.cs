using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class ItModPerfile
    {
        public ItModPerfile()
        {
            ItPerfiles = new HashSet<ItPerfile>();
        }

        public int Id { get; set; }

        public virtual ICollection<ItPerfile> ItPerfiles { get; set; }
    }
}
