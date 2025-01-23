using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class IdVenta
    {
        public Guid Guidventa { get; set; }
        public string? Serie { get; set; }
        public int? Numero { get; set; }
        public string? N { get; set; }
    }
}
