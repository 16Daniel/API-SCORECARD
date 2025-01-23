using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsDBP
{
    public partial class Modificacione
    {
        public int Id { get; set; }
        public string? Modificacion { get; set; }
        public string? ValAntes { get; set; }
        public string? ValDespues { get; set; }
        public string? Justificacion { get; set; }
        public DateTime? Fecha { get; set; }
        public int? Idusuario { get; set; }
        public int? IdPedido { get; set; }
        public bool? Enviado { get; set; }
        public string? PedidoSerie { get; set; }
        public int? Numpedido { get; set; }
        public int? Codarticulo { get; set; }
        public string? Comentario { get; set; }
    }
}
