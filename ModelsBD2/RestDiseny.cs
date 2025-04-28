using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class RestDiseny
    {
        public RestDiseny()
        {
            RestTiquetsdisenies = new HashSet<RestTiquetsdiseny>();
        }

        public short Idgrupo { get; set; }
        public short Iddiseny { get; set; }
        public int? Idioma { get; set; }
        public string? Ivaincluido { get; set; }
        public string? Esmodelo { get; set; }
        public short? Tipodocumento { get; set; }
        public string? Descripcion { get; set; }
        public byte[]? Imagen { get; set; }
        public string? Esdefecto { get; set; }
        public bool? Ocultarptotales { get; set; }
        public byte[] Version { get; set; } = null!;

        public virtual ICollection<RestTiquetsdiseny> RestTiquetsdisenies { get; set; }
    }
}
