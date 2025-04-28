using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsDBRebel
{
    public partial class PhotoBathRoomsOverallStatus
    {
        public int Id { get; set; }
        public int BathroomsoverallstatusId { get; set; }
        public string Photo { get; set; } = null!;
        public int Type { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual BathRoomsOverallStatus Bathroomsoverallstatus { get; set; } = null!;
    }
}
