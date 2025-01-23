using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsDBRebel
{
    public partial class InventarioMensualRegistro
    {
        public int Id { get; set; }
        public int? City { get; set; }
        public int? Sucursal { get; set; }
        public string Captura { get; set; } = null!;
        public DateTime? DateCaptura { get; set; }
        public bool Procesado { get; set; }
    }
}
