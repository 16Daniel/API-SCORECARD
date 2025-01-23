using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsDBRebel
{
    public partial class CatWorkShift
    {
        public CatWorkShift()
        {
            Tasks = new HashSet<Task>();
        }

        public int Id { get; set; }
        public string Workshift { get; set; } = null!;
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual ICollection<Task> Tasks { get; set; }
    }
}
