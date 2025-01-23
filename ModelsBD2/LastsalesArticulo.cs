using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class LastsalesArticulo
    {
        public LastsalesArticulo()
        {
            LastsalesArticuloslins = new HashSet<LastsalesArticuloslin>();
        }

        public int Codarticulo { get; set; }
        public string? Usarnumserie { get; set; }
        public string? Descripcion { get; set; }
        public short? Dpto { get; set; }
        public short? Seccion { get; set; }
        public short? Familia { get; set; }
        public short? Subfamilia { get; set; }
        public short? Linea { get; set; }
        public string? Temporada { get; set; }
        public int? Marca { get; set; }
        public string? Norma { get; set; }
        public string? Tacon { get; set; }
        public string? Composicion { get; set; }
        public string? Descatalogado { get; set; }
        public int? Tipo { get; set; }
        public string? Refproveedor { get; set; }
        public string? Tipoarticulo { get; set; }

        public virtual ICollection<LastsalesArticuloslin> LastsalesArticuloslins { get; set; }
    }
}
