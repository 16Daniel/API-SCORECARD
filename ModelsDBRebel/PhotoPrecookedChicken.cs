using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsDBRebel
{
    public partial class PhotoPrecookedChicken
    {
        public int Id { get; set; }
        public int PrecookedChickenId { get; set; }
        public int Type { get; set; }
        public string Photo { get; set; } = null!;
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual PrecookedChicken PrecookedChicken { get; set; } = null!;
    }
}
