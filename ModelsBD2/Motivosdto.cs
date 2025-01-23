using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Motivosdto
    {
        public Motivosdto()
        {
            IdTienda = new HashSet<NetTiendum>();
        }

        public int Idmotivo { get; set; }
        public string? Descripcion { get; set; }
        public double? Dto { get; set; }
        public bool? Dtomodificable { get; set; }
        public byte[] Version { get; set; } = null!;
        public short? Aplicable { get; set; }
        public short? Tipo { get; set; }
        public string? Mascara { get; set; }
        public bool? Sobredto { get; set; }
        public bool? Sobrecambioprecio { get; set; }
        public string? Descripcionaena { get; set; }
        public bool? Trassubtotal { get; set; }

        public virtual ICollection<NetTiendum> IdTienda { get; set; }
    }
}
