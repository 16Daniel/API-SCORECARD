using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Arqueo
    {
        public int Fo { get; set; }
        public string Arqueo1 { get; set; } = null!;
        public string Caja { get; set; } = null!;
        public double Numero { get; set; }
        public int? Codvendedor { get; set; }
        public DateTime? Fecha { get; set; }
        public string? Hora { get; set; }
        public double? Total { get; set; }
        public double? Descuadre { get; set; }
        public int? Punteo { get; set; }
        public int? Sesion { get; set; }
        public string? Seriefacp { get; set; }
        public int? Numfacp { get; set; }
        public string? Seriefacn { get; set; }
        public int? Numfacn { get; set; }
        public double? Acumulado { get; set; }
        public double? Acumuladon { get; set; }
        public int? Nummesasabiertas { get; set; }
        public double? Importemesasabiertas { get; set; }
        public int? Numventasimpresas { get; set; }
        public double? Importeventasimpresas { get; set; }
        public string? Observaciones { get; set; }
        public string? Cleancashcontrolcode1 { get; set; }
        public bool? Cerrado { get; set; }
    }
}
