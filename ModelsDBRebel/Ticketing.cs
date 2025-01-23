using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsDBRebel
{
    public partial class Ticketing
    {
        public Ticketing()
        {
            CommentTicketings = new HashSet<CommentTicketing>();
            PhotoTicketings = new HashSet<PhotoTicketing>();
        }

        public int Id { get; set; }
        public int BranchId { get; set; }
        public bool Status { get; set; }
        public int WhereAreYouLocated { get; set; }
        public string SpecificLocation { get; set; } = null!;
        public int Category { get; set; }
        public string NoTicket { get; set; } = null!;
        public DateTime DateOpen { get; set; }
        public DateTime? DateClosed { get; set; }
        public decimal? Cost { get; set; }
        public string DescribeProblem { get; set; } = null!;
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual CatTicketing CategoryNavigation { get; set; } = null!;
        public virtual User CreatedByNavigation { get; set; } = null!;
        public virtual CatBranchLocate WhereAreYouLocatedNavigation { get; set; } = null!;
        public virtual ICollection<CommentTicketing> CommentTicketings { get; set; }
        public virtual ICollection<PhotoTicketing> PhotoTicketings { get; set; }
    }
}
