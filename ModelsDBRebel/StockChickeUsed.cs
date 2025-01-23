using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsDBRebel
{
    public partial class StockChickeUsed
    {
        public int Id { get; set; }
        public int StockChickenId { get; set; }
        public decimal AmountUsed { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual User CreatedByNavigation { get; set; } = null!;
        public virtual StockChicken StockChicken { get; set; } = null!;
    }
}
