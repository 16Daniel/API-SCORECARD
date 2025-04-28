using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Favoritosturno
    {
        public int Codturno { get; set; }
        public int Posicion { get; set; }
        public int? Codfavorito { get; set; }
        public byte[]? Version { get; set; }

        public virtual Turno CodturnoNavigation { get; set; } = null!;
    }
}
