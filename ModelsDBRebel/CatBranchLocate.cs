using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsDBRebel
{
    public partial class CatBranchLocate
    {
        public CatBranchLocate()
        {
            Ticketings = new HashSet<Ticketing>();
        }

        public int Id { get; set; }
        public string Locate { get; set; } = null!;
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual ICollection<Ticketing> Ticketings { get; set; }
    }
}
