using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Registroempleado
    {
        public int Fo { get; set; }
        public int Codempleado { get; set; }
        public DateTime Dia { get; set; }
        public DateTime Horain { get; set; }
        public DateTime Horaout { get; set; }
        public double? Horas { get; set; }
        public double? Ventas { get; set; }
        public int? Numventas { get; set; }
        public int? Z { get; set; }
        public string Caja { get; set; } = null!;
        public double? Horasnormal { get; set; }
        public double? Horasextra { get; set; }
        public double? Costehora { get; set; }
        public double? Costehoraextra { get; set; }
        public int? Codmotivo { get; set; }
        public int? Codmotivoentrada { get; set; }
    }
}
