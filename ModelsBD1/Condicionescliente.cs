using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Condicionescliente
    {
        public int Idtarifav { get; set; }
        public int Numlinea { get; set; }
        public int? Dpto { get; set; }
        public int? Seccion { get; set; }
        public int? Familia { get; set; }
        public int? Subfamilia { get; set; }
        public int? Marca { get; set; }
        public int? Linea { get; set; }
        public string? Referencia { get; set; }
        public string? Condiciones { get; set; }
    }
}
