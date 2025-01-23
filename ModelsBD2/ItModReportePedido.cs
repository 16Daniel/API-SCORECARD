using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class ItModReportePedido
    {
        public ItModReportePedido()
        {
            ItPerfiles = new HashSet<ItPerfile>();
        }

        public int Id { get; set; }

        public virtual ICollection<ItPerfile> ItPerfiles { get; set; }
    }
}
