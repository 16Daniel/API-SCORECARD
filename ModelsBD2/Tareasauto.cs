using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Tareasauto
    {
        public Tareasauto()
        {
            TareasautoLogs = new HashSet<TareasautoLog>();
        }

        public int Idtarea { get; set; }
        public int Accion { get; set; }
        public int? Tipofront { get; set; }
        public int? Z { get; set; }
        public string? Caja { get; set; }
        public string? Param1 { get; set; }
        public string? Param2 { get; set; }
        public bool? Bloqueado { get; set; }
        public DateTime? Fechabloqueado { get; set; }

        public virtual ICollection<TareasautoLog> TareasautoLogs { get; set; }
    }
}
