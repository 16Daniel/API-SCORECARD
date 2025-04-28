using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class RemDisenysdoc
    {
        public int Idfront { get; set; }
        public short Tipo { get; set; }
        public int Grupo { get; set; }
        public int Codigo { get; set; }
        public int Nuevo { get; set; }
        public byte[]? Version { get; set; }
        public int? Codalternativo { get; set; }
        public DateTime? Desdealternativo { get; set; }
        public DateTime? Hastaalternativo { get; set; }
    }
}
