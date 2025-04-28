using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Favoritoscab
    {
        public Favoritoscab()
        {
            Favoritosidiomas = new HashSet<Favoritosidioma>();
            Favoritoslins = new HashSet<Favoritoslin>();
            IdFavoritoscabs = new HashSet<IdFavoritoscab>();
            NetFamiliasTienda = new HashSet<NetFamiliasTiendum>();
        }

        public int Codfavorito { get; set; }
        public string? Descripcion { get; set; }
        public byte[]? Imagen { get; set; }
        public int? Colorfondo { get; set; }
        public int? Colortexto { get; set; }
        public string? Visibleweb { get; set; }
        public byte[] Version { get; set; } = null!;
        public int? Posicion { get; set; }
        public string? Centro { get; set; }
        public DateTime? Fechaini { get; set; }
        public DateTime? Fechafin { get; set; }
        public bool? Descatalogado { get; set; }

        public virtual ICollection<Favoritosidioma> Favoritosidiomas { get; set; }
        public virtual ICollection<Favoritoslin> Favoritoslins { get; set; }
        public virtual ICollection<IdFavoritoscab> IdFavoritoscabs { get; set; }
        public virtual ICollection<NetFamiliasTiendum> NetFamiliasTienda { get; set; }
    }
}
