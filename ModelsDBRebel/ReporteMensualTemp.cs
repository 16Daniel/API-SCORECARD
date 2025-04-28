using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsDBRebel
{
    public partial class ReporteMensualTemp
    {
        public int Id { get; set; }
        public int? City { get; set; }
        public int? Regional { get; set; }
        public string? Json { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? Registro { get; set; }
    }
}
