using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class RemFrontsupdatelin
    {
        public int Idupdate { get; set; }
        public string Pto { get; set; } = null!;
        public string? Msgerror { get; set; }

        public virtual RemFrontsupdate IdupdateNavigation { get; set; } = null!;
    }
}
