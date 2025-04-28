using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsDBRebel
{
    public partial class RequestTransfer
    {
        public int Id { get; set; }
        public int Type { get; set; }
        public int Status { get; set; }
        public int FromBranchId { get; set; }
        public int ToBranchId { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan Time { get; set; }
        public int ProductId { get; set; }
        public string? Code { get; set; }
        public string Amount { get; set; } = null!;
        public string Comment { get; set; } = null!;
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual User CreatedByNavigation { get; set; } = null!;
        public virtual CatStatusRequestTransfer StatusNavigation { get; set; } = null!;
    }
}
