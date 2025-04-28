using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsDBRebel
{
    public partial class CatState
    {
        public CatState()
        {
            CatSucursals = new HashSet<CatSucursal>();
            Users = new HashSet<User>();
        }

        public int Id { get; set; }
        public string State { get; set; } = null!;
        public bool Status { get; set; }

        public virtual ICollection<CatSucursal> CatSucursals { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
