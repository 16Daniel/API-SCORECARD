using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsDBRebel
{
    public partial class PhotoPeopleCounting
    {
        public int Id { get; set; }
        public int PeopleId { get; set; }
        public string Photo { get; set; } = null!;
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual PeopleCounting People { get; set; } = null!;
    }
}
