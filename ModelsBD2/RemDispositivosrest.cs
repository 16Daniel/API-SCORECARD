using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class RemDispositivosrest
    {
        public RemDispositivosrest()
        {
            RemRegistrodispositivosrests = new HashSet<RemRegistrodispositivosrest>();
        }

        public int Idfront { get; set; }
        public string Terminal { get; set; } = null!;
        public string Tipodispositivo { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string? Opciones { get; set; }
        public string? Secuencia { get; set; }
        public string? Secuencia2 { get; set; }
        public short? Gruposecuencias { get; set; }
        public short? Numcaja { get; set; }
        public string? Impresoracajon { get; set; }

        public virtual RemFront IdfrontNavigation { get; set; } = null!;
        public virtual ICollection<RemRegistrodispositivosrest> RemRegistrodispositivosrests { get; set; }
    }
}
