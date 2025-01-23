using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsDBRebel
{
    public partial class PhotoEntriesChargedAsDeliveryNote
    {
        public int Id { get; set; }
        public int EntriesChargedAsDeliveryNoteId { get; set; }
        public int Type { get; set; }
        public string Photo { get; set; } = null!;
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual EntriesChargedAsDeliveryNote EntriesChargedAsDeliveryNote { get; set; } = null!;
    }
}
