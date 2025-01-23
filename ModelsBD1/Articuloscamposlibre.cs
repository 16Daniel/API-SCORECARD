using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Articuloscamposlibre
    {
        public int Codarticulo { get; set; }
        public string? Clasificacion { get; set; }
        public double? Precioproveedor { get; set; }
        public string? ClasificacionGad { get; set; }
        public string? ClasificacionGloto { get; set; }
        public string? ClasificacionHelote { get; set; }
        public string? ClasificacionVolcan { get; set; }
        public string? EntraImpoPostres { get; set; }
        public string? Unidadessat { get; set; }
        public string? Catalogosat { get; set; }
        public string? Tipo { get; set; }
        public int? ValorAyc { get; set; }
        public string? TipoDelArticulo { get; set; }
        public string? Inventariable { get; set; }
        public string? PromocionesUber { get; set; }
        public string? VentaHeineken { get; set; }
        public string? Cerveza { get; set; }
        public string? Regulariza { get; set; }
        public string? UnidadmedidaReg { get; set; }
        public string? Inducida { get; set; }
        public string? Rasurado { get; set; }
        public string? Lunch { get; set; }
        public string? Filtro { get; set; }
        public string? RegularizaSemanal { get; set; }

        public virtual Articulo1 CodarticuloNavigation { get; set; } = null!;
    }
}
