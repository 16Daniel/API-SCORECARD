using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class RemRegistrodispositivosrest
    {
        public int Idfront { get; set; }
        public string Terminal { get; set; } = null!;
        public string Tipodispositivo { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string Clave { get; set; } = null!;
        public string Nombrevalor { get; set; } = null!;
        public short? Tipo { get; set; }
        public string? Valor { get; set; }

        public virtual RemDispositivosrest RemDispositivosrest { get; set; } = null!;
    }
}
