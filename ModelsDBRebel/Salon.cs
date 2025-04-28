using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsDBRebel
{
    public partial class Salon
    {
        public Salon()
        {
            PhotoSalons = new HashSet<PhotoSalon>();
        }

        public int Id { get; set; }
        public int BranchId { get; set; }
        public bool AccessDoors { get; set; }
        public string? CommentAccessDoors { get; set; }
        public bool Badges { get; set; }
        public string? CommentBadges { get; set; }
        public bool Luminaires { get; set; }
        public string? CommentLuminaires { get; set; }
        public bool Switches { get; set; }
        public string? CommentSwitches { get; set; }
        public bool FurnitureOne { get; set; }
        public string? CommentFurnitureOne { get; set; }
        public bool FurnitureTwo { get; set; }
        public string? CommentFurnitureTwo { get; set; }
        public bool Boths { get; set; }
        public string? CommentBoths { get; set; }
        public bool FireExtinguishers { get; set; }
        public string? CommentFireExtinguishers { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual ICollection<PhotoSalon> PhotoSalons { get; set; }
    }
}
