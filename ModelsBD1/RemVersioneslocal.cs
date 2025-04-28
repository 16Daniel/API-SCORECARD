using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class RemVersioneslocal
    {
        public int Idtabla { get; set; }
        public string Clave { get; set; } = null!;
        public long? Versionimp { get; set; }
        public long? Versionexp { get; set; }
    }
}
