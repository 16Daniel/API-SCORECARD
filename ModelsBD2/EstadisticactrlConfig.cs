using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class EstadisticactrlConfig
    {
        public int Idinforme { get; set; }
        public int Codusuario { get; set; }
        public byte[]? Report { get; set; }
        public byte[]? Columns { get; set; }
        public byte[]? Styles { get; set; }
        public string? Datosadicionales { get; set; }
    }
}
