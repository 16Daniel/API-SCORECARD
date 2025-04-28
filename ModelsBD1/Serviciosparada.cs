using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Serviciosparada
    {
        public string Serie { get; set; } = null!;
        public int Numero { get; set; }
        public double Idintervencion { get; set; }
        public int Codlinparada { get; set; }
        public int Codparada { get; set; }
        public string? Horainicio { get; set; }
        public string? Horafin { get; set; }
        public double? Tiempo { get; set; }

        public virtual Motivosparada CodparadaNavigation { get; set; } = null!;
        public virtual Servicio Servicio { get; set; } = null!;
    }
}
