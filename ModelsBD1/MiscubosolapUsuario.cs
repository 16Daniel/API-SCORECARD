using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class MiscubosolapUsuario
    {
        public int Idusuario { get; set; }
        public int Idcubo { get; set; }

        public virtual Miscubosolap IdcuboNavigation { get; set; } = null!;
    }
}
