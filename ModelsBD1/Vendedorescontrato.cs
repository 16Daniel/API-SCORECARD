using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Vendedorescontrato
    {
        public int Codvendedor { get; set; }
        public int Codvclin { get; set; }
        public DateTime Fechainicio { get; set; }
        public DateTime Fechafin { get; set; }
        public int Codcontrato { get; set; }
        public string? Codalmacen { get; set; }
        public double Horassemana { get; set; }
        public double Horasdia { get; set; }
        public int Codcategoria { get; set; }
        public byte[]? Version { get; set; }
    }
}
