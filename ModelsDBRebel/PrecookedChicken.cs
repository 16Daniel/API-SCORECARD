using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsDBRebel
{
    public partial class PrecookedChicken
    {
        public PrecookedChicken()
        {
            PhotoPrecookedChickens = new HashSet<PhotoPrecookedChicken>();
        }

        public int Id { get; set; }
        public int BranchId { get; set; }
        public bool PrecookedChickenOnTheTable { get; set; }
        public int? AmountPrecookedChickenOnTheTable { get; set; }
        public int? AmountPrecookedChickenInGeneral { get; set; }
        public bool PrecookedChickenInGeneral { get; set; }
        public int? AmountBonelesOrPrecookedPotatoes { get; set; }
        public bool BonelesOrPrecookedPotatoes { get; set; }
        public string? CommentPrecookedChickenOnTheTable { get; set; }
        public string? CommentPrecookedChickenInGeneral { get; set; }
        public string? CommentBonelesOrPrecookedPotatoes { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual User CreatedByNavigation { get; set; } = null!;
        public virtual ICollection<PhotoPrecookedChicken> PhotoPrecookedChickens { get; set; }
    }
}
