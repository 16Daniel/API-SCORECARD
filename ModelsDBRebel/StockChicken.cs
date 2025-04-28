using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsDBRebel
{
    public partial class StockChicken
    {
        public StockChicken()
        {
            StockChickeUseds = new HashSet<StockChickeUsed>();
        }

        public int Id { get; set; }
        public int? Branch { get; set; }
        public string Code { get; set; } = null!;
        public decimal Amount { get; set; }
        public int StatusId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual User CreatedByNavigation { get; set; } = null!;
        public virtual CatStatusStockChicken Status { get; set; } = null!;
        public virtual User? UpdatedByNavigation { get; set; }
        public virtual ICollection<StockChickeUsed> StockChickeUseds { get; set; }
    }
}
