using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class SisdiVwAlmacenFrontSeries
    {
        public string Codalmacen { get; set; } = null!;
        public string? Nombrealmacen { get; set; }
        public string? Centrocoste { get; set; }
        public int Idfront { get; set; }
        public int Cajafront { get; set; }
        public string? Serie { get; set; }
        public string? Caja { get; set; }
        public string? Codalmventas { get; set; }
        public string? Serietiquets { get; set; }
        public string? Seriefacturas { get; set; }
        public string? Serieinvitaciones { get; set; }
        public string? Seriealbaranes { get; set; }
        public string? Seriereservas { get; set; }
        public string? Serieextras { get; set; }
        public string? Seriecompras { get; set; }
        public string? Serieecuenta { get; set; }
        public string? Serieinventario { get; set; }
        public string? Seriecobroscuenta { get; set; }
        public string? Serieabonostiquets { get; set; }
        public string? Serieabonosfacturas { get; set; }
        public string? Serieabonosalbaranes { get; set; }
        public string? Seriepedidos { get; set; }
    }
}
