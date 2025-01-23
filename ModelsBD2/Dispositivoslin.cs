using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Dispositivoslin
    {
        public int Idterminal { get; set; }
        public string Tipodispositivo { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public int Posicion { get; set; }
        public string? Secuencia { get; set; }

        public virtual Dispositivo Dispositivo { get; set; } = null!;
    }
}
