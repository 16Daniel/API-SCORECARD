using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Hcuposdium
    {
        public int Idhotel { get; set; }
        public int Codintermediario { get; set; }
        public DateTime Fecha { get; set; }
        public int Tipocupo { get; set; }
        public int Contratado { get; set; }
        public int Reservado { get; set; }
        public int Cancelado { get; set; }
        public int Release { get; set; }
        public int? Tiporelease { get; set; }
        public double? Comision { get; set; }
        public bool? Pendientedescarga { get; set; }
        public int Diferenciacontratado { get; set; }
        public int? Estanciaminima { get; set; }

        public virtual Cliente CodintermediarioNavigation { get; set; } = null!;
    }
}
