using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsDBRebel
{
    public partial class CatAmount
    {
        public string Id { get; set; } = null!;
        public string? Amount { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
