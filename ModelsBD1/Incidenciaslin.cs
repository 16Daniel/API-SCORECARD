using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Incidenciaslin
    {
        public int Idincidencia { get; set; }
        public int Idlinea { get; set; }
        public int Codarticulo { get; set; }
        public string Talla { get; set; } = null!;
        public string Color { get; set; } = null!;
        public double? Udscli1 { get; set; }
        public double? Udscli2 { get; set; }
        public double? Udscli3 { get; set; }
        public double? Udscli4 { get; set; }
        public double? Udsprov1 { get; set; }
        public double? Udsprov2 { get; set; }
        public double? Udsprov3 { get; set; }
        public double? Udsprov4 { get; set; }
        public string? Comentario { get; set; }
        public double? Totalcliente { get; set; }
        public double? Totalcentral { get; set; }
        public string? Diferencia { get; set; }
        public int? Codtarifacentral { get; set; }
        public string? Supedido { get; set; }
        public string? Descripartic { get; set; }
        public string? Codbarras { get; set; }
        public int? Idmotivo { get; set; }
        public int? Codformato { get; set; }

        public virtual Incidencia IdincidenciaNavigation { get; set; } = null!;
    }
}
