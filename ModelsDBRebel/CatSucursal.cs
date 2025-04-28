using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsDBRebel
{
    public partial class CatSucursal
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int BranchId { get; set; }
        public int? StateId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool? Status { get; set; }
        public int? RegionId { get; set; }

        public virtual CatState? State { get; set; }
        public virtual User User { get; set; } = null!;
    }
}
