﻿using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class VistaArticulosFacturacion
    {
        public string Numserie { get; set; } = null!;
        public int Numalbaran { get; set; }
        public int? Codarticulo { get; set; }
        public string? Unidadessat { get; set; }
        public string? Catalogosat { get; set; }
        public string? Descripcion { get; set; }
        public double? Unidadestotal { get; set; }
        public double? Precio { get; set; }
        public double? Iva { get; set; }
        public string? Codbarras { get; set; }
        public double? Dto { get; set; }
        public int Expr1 { get; set; }
    }
}
