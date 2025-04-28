using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsDBRebel
{
    public partial class LivingRoomBathroomCleaning
    {
        public LivingRoomBathroomCleaning()
        {
            PhotoLivingRoomBathroomCleanings = new HashSet<PhotoLivingRoomBathroomCleaning>();
        }

        public int Id { get; set; }
        public int BranchId { get; set; }
        public string? Comment { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual User CreatedByNavigation { get; set; } = null!;
        public virtual ICollection<PhotoLivingRoomBathroomCleaning> PhotoLivingRoomBathroomCleanings { get; set; }
    }
}
