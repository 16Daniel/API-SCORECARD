using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Doorbook
    {
        public int Idhotel { get; set; }
        public long Id { get; set; }
        public string? Serie { get; set; }
        public int? Idreserva { get; set; }
        public DateTime? Fecha { get; set; }
        public string? Agencia { get; set; }
        public string? Cliente { get; set; }
        public int? Tipocliente { get; set; }
        public DateTime? Fechaentrada { get; set; }
        public DateTime? Fechasalida { get; set; }
        public int? Habitacion { get; set; }
        public int? Pax { get; set; }
        public string? Regimen { get; set; }
        public int? Tipo { get; set; }
        public string? Observaciones { get; set; }
        public bool? Printed { get; set; }
        public long? Lastid { get; set; }
    }
}
