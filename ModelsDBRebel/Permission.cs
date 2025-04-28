using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsDBRebel
{
    public partial class Permission
    {
        public int Id { get; set; }
        public int? RoleId { get; set; }
        public int? IdCatMenu { get; set; }
        public int? IdCatSubMenu { get; set; }
        public int? IdCatSection { get; set; }
        public bool? Reading { get; set; }
        public bool? Writing { get; set; }
        public bool? Editing { get; set; }
        public bool? Deleting { get; set; }
        public bool? Show { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual CatMenu? IdCatMenuNavigation { get; set; }
        public virtual CatSection? IdCatSectionNavigation { get; set; }
        public virtual CatSubMenu? IdCatSubMenuNavigation { get; set; }
        public virtual CatRole? Role { get; set; }
    }
}
