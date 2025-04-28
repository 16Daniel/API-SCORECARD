using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class EstadisticaUsuario
    {
        public int Idusuario { get; set; }
        public int Tipo { get; set; }
        public int Idinforme { get; set; }
        public string? Favorito { get; set; }

        public virtual Estadistica Estadistica { get; set; } = null!;
    }
}
