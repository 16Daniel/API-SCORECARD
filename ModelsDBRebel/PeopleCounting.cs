using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsDBRebel
{
    public partial class PeopleCounting
    {
        public PeopleCounting()
        {
            PhotoPeopleCountings = new HashSet<PhotoPeopleCounting>();
        }

        public int Id { get; set; }
        public int BranchId { get; set; }
        public int Tables { get; set; }
        public int Dinners { get; set; }
        public string Comment { get; set; } = null!;
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual ICollection<PhotoPeopleCounting> PhotoPeopleCountings { get; set; }
    }
}
