using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class ItPerfile
    {
        public int Id { get; set; }
        public string Perfil { get; set; } = null!;
        public int? IdCuentasUsuario { get; set; }
        public int? IdPerfiles { get; set; }
        public int? IdPedidos { get; set; }
        public int? IdConsultarPedidos { get; set; }
        public int? IdIncidencias { get; set; }
        public int? IdRecibirPedidos { get; set; }
        public int? IdReportePedidos { get; set; }

        public virtual ItModConsultarPedido? IdConsultarPedidosNavigation { get; set; }
        public virtual ItModCuentasUsuario? IdCuentasUsuarioNavigation { get; set; }
        public virtual ItModIncidencia? IdIncidenciasNavigation { get; set; }
        public virtual ItModPedido? IdPedidosNavigation { get; set; }
        public virtual ItModPerfile? IdPerfilesNavigation { get; set; }
        public virtual ItModRecibirPedido? IdRecibirPedidosNavigation { get; set; }
        public virtual ItModReportePedido? IdReportePedidosNavigation { get; set; }
    }
}
