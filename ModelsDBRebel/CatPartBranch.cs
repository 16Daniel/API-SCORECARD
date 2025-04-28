using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsDBRebel
{
    public partial class CatPartBranch
    {
        public CatPartBranch()
        {
            CatSpecificSections = new HashSet<CatSpecificSection>();
            Tickets = new HashSet<Ticket>();
        }

        public int Id { get; set; }
        public string PartBranch { get; set; } = null!;
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual User CreatedByNavigation { get; set; } = null!;
        public virtual User? UpdatedByNavigation { get; set; }
        public virtual ICollection<CatSpecificSection> CatSpecificSections { get; set; }
        public virtual ICollection<Ticket> Tickets { get; set; }
    }
}
