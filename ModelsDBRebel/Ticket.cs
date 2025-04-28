using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsDBRebel
{
    public partial class Ticket
    {
        public Ticket()
        {
            PhotoTickets = new HashSet<PhotoTicket>();
        }

        public int Id { get; set; }
        public int BranchId { get; set; }
        public int PartBranchId { get; set; }
        public int StatusId { get; set; }
        public int SpecificSectionId { get; set; }
        public string Problem { get; set; } = null!;
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual User CreatedByNavigation { get; set; } = null!;
        public virtual CatPartBranch PartBranch { get; set; } = null!;
        public virtual CatSpecificSection SpecificSection { get; set; } = null!;
        public virtual CatStatusTicket Status { get; set; } = null!;
        public virtual User? UpdatedByNavigation { get; set; }
        public virtual ICollection<PhotoTicket> PhotoTickets { get; set; }
    }
}
