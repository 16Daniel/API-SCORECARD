using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class RemDispositivo
    {
        public RemDispositivo()
        {
            RemDispositivoslins = new HashSet<RemDispositivoslin>();
        }

        public int Idfront { get; set; }
        public int Idterminal { get; set; }
        public string Tipodispositivo { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string? Opciones { get; set; }
        public string? Secuencia1 { get; set; }
        public string? Secuencia2 { get; set; }
        public string? Formato { get; set; }
        public int Caracs { get; set; }
        public double? Importe { get; set; }
        public int? Longitud1 { get; set; }
        public int? Longitud2 { get; set; }
        public string? Caja { get; set; }
        public string? Impresoracajon { get; set; }

        public virtual RemFront IdfrontNavigation { get; set; } = null!;
        public virtual ICollection<RemDispositivoslin> RemDispositivoslins { get; set; }
    }
}
