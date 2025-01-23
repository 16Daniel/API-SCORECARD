using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class IdFavoritoscab
    {
        public int Codfavorito { get; set; }
        public Guid Guidgrupofavorito { get; set; }

        public virtual Favoritoscab CodfavoritoNavigation { get; set; } = null!;
    }
}
