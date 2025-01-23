using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Confighorasextra
    {
        public int Codturno { get; set; }
        public string? Horainicio { get; set; }
        public string? Horafin { get; set; }
        public string? Descripcion { get; set; }
        public string? Dlunes { get; set; }
        public string? Dmartes { get; set; }
        public string? Dmiercoles { get; set; }
        public string? Djueves { get; set; }
        public string? Dviernes { get; set; }
        public string? Dsabado { get; set; }
        public string? Ddomingo { get; set; }
        public double? Recargo { get; set; }
    }
}
