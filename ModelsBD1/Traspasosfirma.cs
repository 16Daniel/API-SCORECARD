using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Traspasosfirma
    {
        public string Serie { get; set; } = null!;
        public int Numero { get; set; }
        public string Caja { get; set; } = null!;
        public string N { get; set; } = null!;
        public string? Versionfirma { get; set; }
        public string? Firma { get; set; }
        public string? Claveprivada { get; set; }
        public string? Atdoccodeid { get; set; }

        public virtual Traspasoscab Traspasoscab { get; set; } = null!;
    }
}
