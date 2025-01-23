using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Hmensajesvendedore
    {
        public int Id { get; set; }
        public int? Vendedororigen { get; set; }
        public int? Vendedordestino { get; set; }
        public string? Textomensaje { get; set; }
        public DateTime? Fechacreacion { get; set; }
        public DateTime? Fechaleido { get; set; }
    }
}
