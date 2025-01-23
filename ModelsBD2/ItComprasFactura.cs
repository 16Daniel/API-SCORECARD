using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class ItComprasFactura
    {
        public int Id { get; set; }
        public string Serie { get; set; } = null!;
        public int Numero { get; set; }
        public string Uuid { get; set; } = null!;
        public DateTime Fecha { get; set; }
    }
}
