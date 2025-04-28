using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsDBRebel
{
    public partial class CatStatusRequestTransfer
    {
        public CatStatusRequestTransfer()
        {
            RequestTransfers = new HashSet<RequestTransfer>();
        }

        public int Id { get; set; }
        public string? Status { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual ICollection<RequestTransfer> RequestTransfers { get; set; }
    }
}
