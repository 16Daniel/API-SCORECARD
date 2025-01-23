using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsDBRebel
{
    public partial class CatSubMenu
    {
        public CatSubMenu()
        {
            CatSections = new HashSet<CatSection>();
            Permissions = new HashSet<Permission>();
        }

        public int Id { get; set; }
        public int? MenuId { get; set; }
        public string? Name { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual CatMenu? Menu { get; set; }
        public virtual ICollection<CatSection> CatSections { get; set; }
        public virtual ICollection<Permission> Permissions { get; set; }
    }
}
