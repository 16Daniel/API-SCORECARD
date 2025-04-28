using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsDBRebel
{
    public partial class CommentTicketing
    {
        public int Id { get; set; }
        public int TicketingId { get; set; }
        public string Comment { get; set; } = null!;
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual Ticketing Ticketing { get; set; } = null!;
    }
}
