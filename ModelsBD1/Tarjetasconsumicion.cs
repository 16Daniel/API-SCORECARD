using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Tarjetasconsumicion
    {
        public int Idinicial { get; set; }
        public int Idfinal { get; set; }
        public int Tipotarjeta { get; set; }
        public string? Descripcion { get; set; }
        public DateTime? Caducidad { get; set; }
        public double? Dto { get; set; }
        public int? Tarifa { get; set; }
        public double? Saldoinicial { get; set; }
        public double? Saldoactual { get; set; }
        public string? Valida { get; set; }
        public short? Controluso { get; set; }
        public short? Tipocaducidad { get; set; }
        public short? Imprimir { get; set; }
        public short? Numcopias { get; set; }
        public short? Coddiseny { get; set; }
    }
}
