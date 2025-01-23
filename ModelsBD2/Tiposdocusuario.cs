using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Tiposdocusuario
    {
        public int Codusuario { get; set; }
        public string Documento { get; set; } = null!;
        public int Numlinea { get; set; }
        public int Tipodoc { get; set; }

        public virtual Tiposdoc TipodocNavigation { get; set; } = null!;
    }
}
