using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Ordenesfabcab
    {
        public string Serie { get; set; } = null!;
        public int Numero { get; set; }
        public DateTime? Fechaorden { get; set; }
        public DateTime? Fechafin { get; set; }
        public string? Almacenorigen { get; set; }
        public string? Almacendestino { get; set; }
        public int? Codigoart { get; set; }
        public string Talla { get; set; } = null!;
        public string Color { get; set; } = null!;
        public string? Descripcion { get; set; }
        public string? Referencia { get; set; }
        public double? Unidades { get; set; }
        public string? Acabada { get; set; }
        public string? Fabricando { get; set; }
        public DateTime? Fechainicio { get; set; }
        public string? Preparada { get; set; }
        public string? Observaciones { get; set; }
        public int Numproducto { get; set; }
        public double? Peso { get; set; }
        public double? Prorrateo { get; set; }
        public int? Tarifaprorrateo { get; set; }
        public int? Taller { get; set; }
        public string? Desglosado { get; set; }
        public int? Numetiquetas { get; set; }
        public double? Udmedida2 { get; set; }
        public int? Codvendedor { get; set; }
        public bool? Vienedefo { get; set; }
        public short? EnlaceEmpresaAct { get; set; }
        public short? EnlaceEjercicioAct { get; set; }
        public string? EnlaceUsuarioAct { get; set; }
        public int? EnlaceAsientoAct { get; set; }
        public short? EnlaceEmpresaFin { get; set; }
        public short? EnlaceEjercicioFin { get; set; }
        public string? EnlaceUsuarioFin { get; set; }
        public int? EnlaceAsientoFin { get; set; }
        public DateTime? Fechataller { get; set; }
    }
}
