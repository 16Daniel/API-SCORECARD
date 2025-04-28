using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsDBRebel
{
    public partial class CatMenu
    {
        public CatMenu()
        {
            CatSubMenus = new HashSet<CatSubMenu>();
            Permissions = new HashSet<Permission>();
        }

        public int Id { get; set; }
        public string? Name { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual ICollection<CatSubMenu> CatSubMenus { get; set; }
        public virtual ICollection<Permission> Permissions { get; set; }
    }
}
