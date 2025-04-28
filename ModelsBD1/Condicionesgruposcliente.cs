using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Condicionesgruposcliente
    {
        public int Idgrupo { get; set; }
        public int Grupoor { get; set; }
        public int Grupoand { get; set; }
        public string Incluir { get; set; } = null!;
        public int? Tabla { get; set; }
        public string? Campo { get; set; }
        public string? Operador { get; set; }
        public string? Valor { get; set; }

        public virtual Gruposcliente IdgrupoNavigation { get; set; } = null!;
    }
}
