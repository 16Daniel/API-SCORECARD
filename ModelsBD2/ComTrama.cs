using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class ComTrama
    {
        public ComTrama()
        {
            ComConfigtramas = new HashSet<ComConfigtrama>();
        }

        public int Iddispositivo { get; set; }
        public int Idoperacion { get; set; }
        public int Idtrama { get; set; }
        public int? Longitud { get; set; }
        public string? Marcainicio { get; set; }
        public string? Marcafin { get; set; }
        public string? Activo { get; set; }
        public int? Idtramaresp { get; set; }

        public virtual ComDispositivo IddispositivoNavigation { get; set; } = null!;
        public virtual ComOperacione IdoperacionNavigation { get; set; } = null!;
        public virtual ICollection<ComConfigtrama> ComConfigtramas { get; set; }
    }
}
