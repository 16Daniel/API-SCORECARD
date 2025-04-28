using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class AenaVenta
    {
        public int Z { get; set; }
        public string Caja { get; set; } = null!;
        public int IdVenta { get; set; }
        public int TipoFamilia { get; set; }
        public int TipoSubfamilia { get; set; }
        public int TipoFiscal { get; set; }
        public double ArticulosV { get; set; }
        public double ImpbrutoVsfz { get; set; }
        public double ImpnetoVsfz { get; set; }
        public double ImpdescuentoVsfz { get; set; }
        public double ArticulosD { get; set; }
        public double ImpbrutoDsfz { get; set; }
        public double ImpnetoDsfz { get; set; }
        public double ImpdescuentoDsfz { get; set; }
    }
}
