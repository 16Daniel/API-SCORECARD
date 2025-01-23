using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Conceptosajuste
    {
        public int Id { get; set; }
        public string? Descripcion { get; set; }
        public string? Cuentagastos { get; set; }
        public byte[]? Version { get; set; }
    }
}
