using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Hcuposfecha
    {
        public int Idcupo { get; set; }
        public DateTime Fecha { get; set; }
        public int Reservado { get; set; }
        public int Cancelado { get; set; }
        public int Diferenciacontratado { get; set; }
        public bool Descatalogado { get; set; }
        public byte Pendientedescarga { get; set; }
        public int Release { get; set; }
        public int Contratado { get; set; }
        public int Estanciaminima { get; set; }
        public int Contratadoinicial { get; set; }
        public int? Estanciamaxima { get; set; }

        public virtual Hcupo IdcupoNavigation { get; set; } = null!;
    }
}
