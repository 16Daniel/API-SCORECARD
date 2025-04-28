using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsDBRebel
{
    public partial class BarCleaning
    {
        public BarCleaning()
        {
            PhotoBarCleanings = new HashSet<PhotoBarCleaning>();
        }

        public int Id { get; set; }
        public int BranchId { get; set; }
        public bool IsClean { get; set; }
        public string Comment { get; set; } = null!;
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual ICollection<PhotoBarCleaning> PhotoBarCleanings { get; set; }
    }
}
