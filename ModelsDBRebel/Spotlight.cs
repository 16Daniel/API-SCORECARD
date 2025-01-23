using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsDBRebel
{
    public partial class Spotlight
    {
        public Spotlight()
        {
            PhotoSpotlights = new HashSet<PhotoSpotlight>();
        }

        public int Id { get; set; }
        public int BranchId { get; set; }
        public bool BrokenSpotlight { get; set; }
        public bool SpotlightAutorizados { get; set; }
        public string CommentFoco { get; set; } = null!;
        public string CommentAutorizados { get; set; } = null!;
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual ICollection<PhotoSpotlight> PhotoSpotlights { get; set; }
    }
}
