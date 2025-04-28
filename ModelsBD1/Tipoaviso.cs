using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Tipoaviso
    {
        public Tipoaviso()
        {
            Codempleados = new HashSet<Vendedore>();
        }

        public int Codtipoaviso { get; set; }
        public int? Idparent { get; set; }
        public string? Descripcion { get; set; }
        public int? Tiempo { get; set; }
        public int? Tiempofac { get; set; }
        public int? Codarticulo { get; set; }
        public string? Talla { get; set; }
        public string? Color { get; set; }
        public int? Codcondicion { get; set; }
        public int? Numpresup { get; set; }
        public string? Seriepresup { get; set; }
        public byte[] Version { get; set; } = null!;

        public virtual ICollection<Vendedore> Codempleados { get; set; }
    }
}
