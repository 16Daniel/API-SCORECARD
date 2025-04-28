using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Cargosdto
    {
        public int Codigo { get; set; }
        public int Posicion { get; set; }
        public string? Nombre { get; set; }
        public int Tipo { get; set; }
        public int Definicion { get; set; }
        public int Tipovalor { get; set; }
        public int Tipoiva { get; set; }
        public int Secuencia { get; set; }
        public int? Codimpuesto { get; set; }
        public string? Subcuentaventas { get; set; }
        public string? Subcuentacompras { get; set; }
        public double? Valor { get; set; }
        public string? Visible { get; set; }
        public string? Visiblecompra { get; set; }
        public string? Visibleventa { get; set; }
        public string? Siglas { get; set; }
        public double? Importeminimo { get; set; }
        public string? Codigofiscal { get; set; }
    }
}
