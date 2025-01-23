using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsDBRebel
{
    public partial class Inventario
    {
        public int Id { get; set; }
        public int? Branch { get; set; }
        public decimal InvInicial { get; set; }
        public decimal InvReg { get; set; }
        public decimal Diferencia { get; set; }
        public int? Intentos { get; set; }
        public string? Articulo { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual User CreatedByNavigation { get; set; } = null!;
    }
}
