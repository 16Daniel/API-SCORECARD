using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsDBRebel
{
    public partial class FridgeSalon
    {
        public FridgeSalon()
        {
            PhotoFridgeSalons = new HashSet<PhotoFridgeSalon>();
        }

        public int Id { get; set; }
        public int BranchId { get; set; }
        public bool LayOut { get; set; }
        public bool Shortage { get; set; }
        public string Comment { get; set; } = null!;
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual ICollection<PhotoFridgeSalon> PhotoFridgeSalons { get; set; }
    }
}
