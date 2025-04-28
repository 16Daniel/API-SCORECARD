using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsDBRebel
{
    public partial class Order
    {
        public Order()
        {
            PhotoOrders = new HashSet<PhotoOrder>();
        }

        public int Id { get; set; }
        public int BranchId { get; set; }
        public int AverageTime { get; set; }
        public string Comment { get; set; } = null!;
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual User CreatedByNavigation { get; set; } = null!;
        public virtual ICollection<PhotoOrder> PhotoOrders { get; set; }
    }
}
