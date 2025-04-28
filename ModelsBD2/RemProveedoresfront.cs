using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class RemProveedoresfront
    {
        public int Idfront { get; set; }
        public int Codproveedor { get; set; }
        public int? Idcentralpedido { get; set; }
        public int? Idcentralrecepcion { get; set; }
        public string? Usuarioped { get; set; }
        public string? Passwordped { get; set; }
        public string? Usuariorecep { get; set; }
        public string? Passwordrecep { get; set; }
        public string? Codformapago { get; set; }
        public double? Dtopp { get; set; }
        public double? Dtocomercial { get; set; }
        public string? Regfacturacion { get; set; }
        public string? Factsinimpuestos { get; set; }
    }
}
