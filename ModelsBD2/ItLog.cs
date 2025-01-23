using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class ItLog
    {
        public int Id { get; set; }
        public string? Serie { get; set; }
        public int? Numero { get; set; }
        public int? Op { get; set; }
        public string? Message { get; set; }
        public DateTime? Fecha { get; set; }
    }
}
