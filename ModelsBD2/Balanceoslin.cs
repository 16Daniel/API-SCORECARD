using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Balanceoslin
    {
        public int Codigo { get; set; }
        public int Id { get; set; }
        public int? Codarticulo { get; set; }
        public string? Talla { get; set; }
        public string? Color { get; set; }
        public string? Almorig { get; set; }
        public string? Almdest { get; set; }
        public double? Uds { get; set; }
        public string? Recogertodo { get; set; }

        public virtual Balanceoscab CodigoNavigation { get; set; } = null!;
    }
}
