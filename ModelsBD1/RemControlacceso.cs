using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class RemControlacceso
    {
        public int Idfront { get; set; }
        public DateTime? Fecha { get; set; }
        public DateTime? Fechaact { get; set; }
        public long? Transacciones { get; set; }
        public int? Transaccioneshoy { get; set; }
        public int? Mediatransaccion { get; set; }
        public int? Tipotrans { get; set; }
        public int? Resultado { get; set; }
        public string? Errormsg { get; set; }
        public int? Resultadoact { get; set; }
        public string? Errormsgact { get; set; }
        public DateTime? Fecharecep { get; set; }
        public int? Resultadorecep { get; set; }
        public string? Errormsgrecep { get; set; }
        public int? Resultadoauto { get; set; }
        public string? Errormsgauto { get; set; }
    }
}
