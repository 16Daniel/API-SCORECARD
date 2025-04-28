using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsDashboard
{
    public partial class CatRuta
    {
        public int Id { get; set; }
        public string? Ruta { get; set; }
        public string? Descripcion { get; set; }
        public string? Icon { get; set; }
    }
}
