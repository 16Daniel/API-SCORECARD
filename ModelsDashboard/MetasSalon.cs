using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsDashboard
{
    public partial class MetasSalon
    {
        public int Id { get; set; }
        public int Año { get; set; }
        public int Mes { get; set; }
        public double Meta { get; set; }
        public string Sucursal { get; set; } = null!;
    }
}
