using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsDBRebel
{
    public partial class RiskProduct
    {
        public int Id { get; set; }
        public int BranchId { get; set; }
        public int ProductId { get; set; }
        public string Code { get; set; } = null!;
        public string Comment { get; set; } = null!;
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual User CreatedByNavigation { get; set; } = null!;
    }
}
