using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class TFotosPedidosEntrega
    {
        public int Id { get; set; }
        public int IdPedido { get; set; }
        public string Foto { get; set; } = null!;
        public string Tipo { get; set; } = null!;

        public virtual TPedidosEntrega IdPedidoNavigation { get; set; } = null!;
    }
}
