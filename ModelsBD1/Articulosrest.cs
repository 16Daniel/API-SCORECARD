using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Articulosrest
    {
        public int Codarticulo { get; set; }
        public string? Refteclado { get; set; }
        public int? Impuestoesp { get; set; }
        public string? Pordosis { get; set; }
        public string? Secompra { get; set; }
        public string? Sevende { get; set; }
        public int? Orden { get; set; }
        public string? Nocombinar { get; set; }
        public string? Menu { get; set; }
        public string? Preciolibre { get; set; }
        public double? Preciomax { get; set; }
        public double? Preciomin { get; set; }
        public string? Seleccionableallturnos { get; set; }
        public double? Tara { get; set; }
        public double? Rendimiento { get; set; }
        public string? Esoferta { get; set; }
        public string? Codcupon { get; set; }
        public int? Kcal { get; set; }
        public bool? Factporfranja { get; set; }
        public int? Minfactporhora { get; set; }
        public int? Codtarifafactporhora { get; set; }
        public string? Alergenos { get; set; }
        public bool? Validoprimeruso { get; set; }
        public bool? Completarplatosmenu { get; set; }

        public virtual Articulo1 CodarticuloNavigation { get; set; } = null!;
    }
}
