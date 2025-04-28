using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsDBRebel
{
    public partial class UbicacionesInventario
    {
        public int Id { get; set; }
        public int? Codart { get; set; }
        public string? Jdata { get; set; }
        public string? Idusuario { get; set; }
        public string? Idsucursal { get; set; }
        public int? Vista { get; set; }
        public double? Total { get; set; }
    }
}
