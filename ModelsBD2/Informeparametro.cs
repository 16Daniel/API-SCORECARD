using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Informeparametro
    {
        public int Idinforme { get; set; }
        public int Numparametro { get; set; }
        public string? Nombre { get; set; }
        public string? Caption { get; set; }
        public string? Tipocampo { get; set; }
        public string? Valordef { get; set; }
        public string? Preguntar { get; set; }
        public string? Seleccion { get; set; }
        public string? Camposeleccion { get; set; }

        public virtual Informe IdinformeNavigation { get; set; } = null!;
    }
}
