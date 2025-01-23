using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class CmrcInforme
    {
        public int Idinforme { get; set; }
        public int Ididioma { get; set; }
        public int? Tipo { get; set; }
        public byte[]? Xtrareport { get; set; }
        public string? Texto { get; set; }
        public string? Texto2 { get; set; }
        public string? Descripcion { get; set; }
    }
}
