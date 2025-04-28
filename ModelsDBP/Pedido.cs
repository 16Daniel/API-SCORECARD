using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsDBP
{
    public partial class Pedido
    {
        public int Id { get; set; }
        public string Sucursal { get; set; } = null!;
        public int Proveedor { get; set; }
        public string Jdata { get; set; } = null!;
        public string Estatus { get; set; } = null!;
        public string? Datam { get; set; }
        public DateTime? Fecha { get; set; }
        public string? Numpedido { get; set; }
        public int? Idcal { get; set; }
        public bool? Temporal { get; set; }
    }
}
