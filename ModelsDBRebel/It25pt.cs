using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsDBRebel
{
    public partial class It25pt
    {
        public int Id { get; set; }
        public DateTime? Fechaini { get; set; }
        public int Sala { get; set; }
        public int Mesa { get; set; }
        public int? TotalAyc { get; set; }
        public int? Cobros { get; set; }
        public int? CobrosMinimos { get; set; }
        public int Diferencia { get; set; }
        public string Justificacion { get; set; } = null!;
        public string? Usuario { get; set; }
        public string Sucursal { get; set; } = null!;
        public string? Vendedor { get; set; }
        public int? Codvendedor { get; set; }
    }
}
