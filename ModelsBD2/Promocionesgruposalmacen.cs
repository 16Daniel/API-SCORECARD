using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Promocionesgruposalmacen
    {
        public int Idpromocion { get; set; }
        public int Idgrupo { get; set; }
        public DateTime? Fechainicial { get; set; }
        public DateTime? Horainicial { get; set; }
        public DateTime? Fechafinal { get; set; }
        public DateTime? Horafinal { get; set; }

        public virtual Promocione IdpromocionNavigation { get; set; } = null!;
    }
}
