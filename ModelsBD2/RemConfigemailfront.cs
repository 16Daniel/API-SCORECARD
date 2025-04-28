using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class RemConfigemailfront
    {
        public int Idfront { get; set; }
        public bool? Exportarresz { get; set; }
        public int? Autemail { get; set; }
        public string? Usuario { get; set; }
        public string? Password { get; set; }
        public string? Host { get; set; }
        public int? Port { get; set; }
        public string? Fromemail { get; set; }
        public string? Emailz { get; set; }
        public string? Ccopyz { get; set; }
        public int? Tipoemlz { get; set; }
        public int? Tipoempleado { get; set; }
        public double? Descuadrelimit { get; set; }
        public bool Exportarepez { get; set; }
        public bool? Exportarresx { get; set; }
        public bool? Enviarventa { get; set; }
        public int? Disenyo { get; set; }

        public virtual RemFront IdfrontNavigation { get; set; } = null!;
    }
}
