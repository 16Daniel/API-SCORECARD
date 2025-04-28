using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsDBRebel
{
    public partial class BathRoomsOverallStatus
    {
        public BathRoomsOverallStatus()
        {
            PhotoBathRoomsOverallStatuses = new HashSet<PhotoBathRoomsOverallStatus>();
        }

        public int Id { get; set; }
        public int BranchId { get; set; }
        public bool DoesAnyBathroomLeakMen { get; set; }
        public string? CommentDoesAnyBathroomLeakMen { get; set; }
        public bool IsThereAnyFaultsMen { get; set; }
        public string? CommentAreThereAnyFaultsMen { get; set; }
        public bool DoesAnyBathroomLeakWomen { get; set; }
        public string? CommentDoesAnyBathroomLeakWomen { get; set; }
        public bool IsThereAnyFaultsWomen { get; set; }
        public string? CommentAreThereAnyFaultsWomen { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual ICollection<PhotoBathRoomsOverallStatus> PhotoBathRoomsOverallStatuses { get; set; }
    }
}
