using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class RemCajasfront
    {
        public int Idfront { get; set; }
        public int Cajafront { get; set; }
        public string? Serietiquets { get; set; }
        public string? Seriefacturas { get; set; }
        public string? Serieinvitaciones { get; set; }
        public string? Seriealbaranes { get; set; }
        public string? Seriereservas { get; set; }
        public string? Serieextras { get; set; }
        public string? Seriecompras { get; set; }
        public string? Cajamanager { get; set; }
        public string? Codalmventas { get; set; }
        public string? Codalmrepos { get; set; }
        public string? Codalmmermas { get; set; }
        public DateTime? Horaruptura { get; set; }
        public string? Serieecuenta { get; set; }
        public string? Serieinventario { get; set; }
        public string? Seriecobroscuenta { get; set; }
        public byte[] Version { get; set; } = null!;
        public string? Codalmcompras { get; set; }
        public string? Descripcion { get; set; }
        public string? Serieabonostiquets { get; set; }
        public string? Serieabonosfacturas { get; set; }
        public string? Serieabonosalbaranes { get; set; }
        public bool? Usarseriesabonos { get; set; }
        public string? Seriepedidos { get; set; }
        public string? Cajaseguridad { get; set; }
        public string? TpvAena { get; set; }
        public string? LocalAena { get; set; }
        public string? ContratoAena { get; set; }
        public bool? Usarserieinvitacionimportecero { get; set; }
        public string? Seriepcuenta { get; set; }

        public virtual RemFront IdfrontNavigation { get; set; } = null!;
    }
}
