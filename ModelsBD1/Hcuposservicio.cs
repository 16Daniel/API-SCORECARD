using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Hcuposservicio
    {
        public int Idhotel { get; set; }
        public int Idcupo { get; set; }
        public int Codactividad { get; set; }
        public int Codservicio { get; set; }
        public int? Posicion { get; set; }

        public virtual Tipoasunto CodactividadNavigation { get; set; } = null!;
        public virtual Serviciosglobale CodservicioNavigation { get; set; } = null!;
        public virtual Hcupo IdcupoNavigation { get; set; } = null!;
        public virtual Hotele IdhotelNavigation { get; set; } = null!;
    }
}
