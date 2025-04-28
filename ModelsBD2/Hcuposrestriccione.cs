using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Hcuposrestriccione
    {
        public int Idhotel { get; set; }
        public int Idcupo { get; set; }
        public DateTime Fechainicio { get; set; }
        public DateTime Fechafin { get; set; }
        public int Tiporestriccion { get; set; }
        public int Estado { get; set; }
        public int? Diasestancia { get; set; }
        public bool? Pendientesubida { get; set; }

        public virtual Hcupo IdcupoNavigation { get; set; } = null!;
        public virtual Hotele IdhotelNavigation { get; set; } = null!;
    }
}
