using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsDBRebel
{
    public partial class TaskBranch
    {
        public int TaskId { get; set; }
        public int BranchId { get; set; }

        public virtual Task Task { get; set; } = null!;
    }
}
