using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Tipoempleado
    {
        public int Codtipoempleado { get; set; }
        public string? Descripcion { get; set; }
        public int? Menumesas { get; set; }
        public int? Menutiquets { get; set; }
        public int? Menuusuario { get; set; }
        public string? Visiblealseleccionar { get; set; }
        public string? Regularizar { get; set; }
        public string? Visibleendelivery { get; set; }
        public string? Modificar { get; set; }
        public string? Redondear { get; set; }
        public string? Anular { get; set; }
        public string? Salir { get; set; }
        public string? Opciones { get; set; }
        public int? Menureservas { get; set; }
        public string? Opcionesventa { get; set; }
        public string? Opcionescompra { get; set; }
        public string? Verregul { get; set; }
        public string? Opcioneshotel { get; set; }
        public string? Opcioneshcierre { get; set; }
        public string? Moduloz { get; set; }
        public string? Modulox { get; set; }
        public string? Moduloz2 { get; set; }
        public string? Modulox2 { get; set; }
        public string? Idioma { get; set; }
        public byte[] Version { get; set; } = null!;
        public double? Dtomax { get; set; }
        public double? Retempresaprop { get; set; }
        public double? Costehora { get; set; }
        public double? Costehoraextra { get; set; }
        public int? Nivel { get; set; }
        public bool? Acccambiosala { get; set; }
        public string? Opcionesgraficas { get; set; }
        public bool? Cajonporvendedor { get; set; }
        public string? Opcionescajafuerte { get; set; }
        public string? Opcionestraspasos { get; set; }
        public string? Opcionesownpack { get; set; }
    }
}
