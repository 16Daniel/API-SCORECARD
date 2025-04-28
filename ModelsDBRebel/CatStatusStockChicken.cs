using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsDBRebel
{
    public partial class CatStatusStockChicken
    {
        public CatStatusStockChicken()
        {
            StockChickens = new HashSet<StockChicken>();
        }

        public int Id { get; set; }
        public string? Status { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual ICollection<StockChicken> StockChickens { get; set; }
    }
}
