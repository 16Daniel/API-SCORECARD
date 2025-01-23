using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsDBP
{
    public partial class PedidosSucursale
    {
        public int Id { get; set; }
        public int Sucursal { get; set; }
        public int Proveedor { get; set; }
        public string Jdata { get; set; } = null!;
        public string Estatus { get; set; } = null!;
        public string? Datam { get; set; }
        public DateTime Fecha { get; set; }
        public string? Numpedido { get; set; }
    }
}
