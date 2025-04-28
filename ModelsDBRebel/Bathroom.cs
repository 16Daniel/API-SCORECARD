using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsDBRebel
{
    public partial class Bathroom
    {
        public Bathroom()
        {
            PhotoBathrooms = new HashSet<PhotoBathroom>();
        }

        public int Id { get; set; }
        public int BranchId { get; set; }
        public bool Urinals { get; set; }
        public string? CommentUrinals { get; set; }
        public bool HandWashBasin { get; set; }
        public string? CommentHandWashBasin { get; set; }
        public bool Luminaires { get; set; }
        public string? CommentLuminaires { get; set; }
        public bool Doors { get; set; }
        public string? CommentDoors { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual ICollection<PhotoBathroom> PhotoBathrooms { get; set; }
    }
}
