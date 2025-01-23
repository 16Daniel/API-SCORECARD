using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsDBRebel
{
    public partial class Task
    {
        public Task()
        {
            FormFields = new HashSet<FormField>();
            TaskBranches = new HashSet<TaskBranch>();
        }

        public int Id { get; set; }
        public string Icon { get; set; } = null!;
        public int AssignedToId { get; set; }
        public int WorkshiftId { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual CatAssignedTo AssignedTo { get; set; } = null!;
        public virtual User CreatedByNavigation { get; set; } = null!;
        public virtual User? UpdatedByNavigation { get; set; }
        public virtual CatWorkShift Workshift { get; set; } = null!;
        public virtual ICollection<FormField> FormFields { get; set; }
        public virtual ICollection<TaskBranch> TaskBranches { get; set; }
    }
}
