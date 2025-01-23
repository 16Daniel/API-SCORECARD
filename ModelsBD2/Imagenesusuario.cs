using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Imagenesusuario
    {
        public int Codusuario { get; set; }
        public int Tipo { get; set; }
        public byte[]? Imagen { get; set; }
    }
}
