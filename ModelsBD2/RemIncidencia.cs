using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class RemIncidencia
    {
        public int Idincidencia { get; set; }
        public int Tipo { get; set; }
        public string? Serie { get; set; }
        public int? Numero { get; set; }
        public DateTime? Fechadoc { get; set; }
        public int? Codproveedor { get; set; }
        public int? Idincidenciaorig { get; set; }
    }
}
