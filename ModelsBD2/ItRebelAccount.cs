using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class ItRebelAccount
    {
        public int? Id { get; set; }
        public int? Codvendedor { get; set; }
        public string Usuario { get; set; } = null!;
        public string Contraseña { get; set; } = null!;
        public int? IdPerfil { get; set; }
        public string? Codalmacen { get; set; }
        public int? Codproveedor { get; set; }
        public string Descatalogado { get; set; } = null!;
        public double MargenPu { get; set; }
        public double MargenUds { get; set; }
        public string Fiscal { get; set; } = null!;
        public string? Correo { get; set; }
        public string RecibirIncidencias { get; set; } = null!;

        public virtual Proveedore? CodproveedorNavigation { get; set; }
        public virtual Vendedore? CodvendedorNavigation { get; set; }
    }
}
