using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class SmsEnviado
    {
        public int Idsms { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime Hora { get; set; }
        public string Mobil { get; set; } = null!;
        public int? Codusuario { get; set; }

        public virtual SmsTexto IdsmsNavigation { get; set; } = null!;
    }
}
