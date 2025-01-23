using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Asuntosautomatico
    {
        public int Idclave { get; set; }
        public int Idcliente { get; set; }
        public string Serieaviso { get; set; } = null!;
        public int Codurgencia { get; set; }
        public string Codlugar { get; set; } = null!;
        public int Idtipoaviso { get; set; }
        public int Idcondiciones { get; set; }
        public int Idtipoasunto { get; set; }
        public string? Tipoequipo { get; set; }
        public DateTime Fechaproximoaviso { get; set; }
        public int Fintervalo { get; set; }
        public int Funidades { get; set; }
        public int? Creador { get; set; }
        public string? Para { get; set; }
        public double? Manodeobra { get; set; }
        public double? Desplazamiento { get; set; }
        public double? Recambios { get; set; }
        public int? Subcontrata { get; set; }
        public string? Activado { get; set; }

        public virtual Cliente IdclienteNavigation { get; set; } = null!;
    }
}
