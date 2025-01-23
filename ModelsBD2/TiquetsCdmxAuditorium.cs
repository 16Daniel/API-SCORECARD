using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class TiquetsCdmxAuditorium
    {
        public string Origen { get; set; } = null!;
        public string Tipodocumento { get; set; } = null!;
        public string Serie { get; set; } = null!;
        public int Numero { get; set; }
        public string N { get; set; } = null!;
        public short Posicion { get; set; }
        public string? Nombrealmacen { get; set; }
        public DateTime? Fechadocumento { get; set; }
        public double? Importe { get; set; }
        public string? Descripcion { get; set; }
    }
}
