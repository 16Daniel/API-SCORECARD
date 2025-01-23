using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsDBRebel
{
    public partial class CatSection
    {
        public CatSection()
        {
            Permissions = new HashSet<Permission>();
        }

        public int Id { get; set; }
        public int? SubMenuId { get; set; }
        public string? Name { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual CatSubMenu? SubMenu { get; set; }
        public virtual ICollection<Permission> Permissions { get; set; }
    }
}
