using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsDBRebel
{
    public partial class PhotoWaitlistTable
    {
        public int Id { get; set; }
        public int WaitlistTableId { get; set; }
        public string Photo { get; set; } = null!;
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual User CreatedByNavigation { get; set; } = null!;
        public virtual WaitlistTable WaitlistTable { get; set; } = null!;
    }
}
