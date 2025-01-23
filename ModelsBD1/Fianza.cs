using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Fianza
    {
        public int Idfianza { get; set; }
        public string? Descripcion { get; set; }
        public byte[] Version { get; set; } = null!;
        public double? Importedef { get; set; }
        public string? Cuentagasto { get; set; }
        public string? Cuentaingreso { get; set; }
    }
}
