using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsDBRebel
{
    public partial class GeneralCleaning
    {
        public GeneralCleaning()
        {
            PhotoGeneralCleanings = new HashSet<PhotoGeneralCleaning>();
        }

        public int Id { get; set; }
        public int BranchId { get; set; }
        public string TableN { get; set; } = null!;
        public bool CleanlinessInSalon { get; set; }
        public bool CleaningInBuckets { get; set; }
        public bool CleaningBooths { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual ICollection<PhotoGeneralCleaning> PhotoGeneralCleanings { get; set; }
    }
}
