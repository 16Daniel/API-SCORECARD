using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class ComConfigtrama
    {
        public int Iddispositivo { get; set; }
        public int Idoperacion { get; set; }
        public int Idtrama { get; set; }
        public int Idcampo { get; set; }
        public int Tipocampo { get; set; }
        public string? Nombrecampo { get; set; }
        public int? Posinicio { get; set; }
        public int? Longitud { get; set; }
        public string? Alineacion { get; set; }
        public string? Tipo { get; set; }
        public string? Relleno { get; set; }
        public string? Valordefecto { get; set; }

        public virtual ComTrama Id { get; set; } = null!;
    }
}
