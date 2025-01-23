using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsDBP
{
    public partial class ValidacionPedido
    {
        public int Id { get; set; }
        public bool Status { get; set; }
        public int? Idu { get; set; }
    }
}
