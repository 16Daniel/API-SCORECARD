using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsDBRebel
{
    public partial class EntriesChargedAsDeliveryNote
    {
        public EntriesChargedAsDeliveryNote()
        {
            PhotoEntriesChargedAsDeliveryNotes = new HashSet<PhotoEntriesChargedAsDeliveryNote>();
        }

        public int Id { get; set; }
        public int BranchId { get; set; }
        public string CommentDirectDeliveriesPerDay { get; set; } = null!;
        public int RevisionNumber { get; set; }
        public string CommentRevisionNumber { get; set; } = null!;
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual ICollection<PhotoEntriesChargedAsDeliveryNote> PhotoEntriesChargedAsDeliveryNotes { get; set; }
    }
}
