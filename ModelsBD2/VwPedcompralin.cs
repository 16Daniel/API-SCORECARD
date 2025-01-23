using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class VwPedcompralin
    {
        public string? Nif20 { get; set; }
        public DateTime? Fechapedido { get; set; }
        public double? Totreq { get; set; }
        public double? Totiva { get; set; }
        public string Numserie { get; set; } = null!;
        public int Numpedido { get; set; }
        public string N { get; set; } = null!;
        public int Numlinea { get; set; }
        public int? Codarticulo { get; set; }
        public string? Referencia { get; set; }
        public string Talla { get; set; } = null!;
        public string Color { get; set; } = null!;
        public string? Descripcion { get; set; }
        public double? Unid1 { get; set; }
        public double? Unid2 { get; set; }
        public double? Unid3 { get; set; }
        public double? Unid4 { get; set; }
        public double? Unidadestotal { get; set; }
        public double? Unidadesrec { get; set; }
        public double? Unidadespen { get; set; }
        public double? Precio { get; set; }
        public double? Dto { get; set; }
        public short? Tipoimpuesto { get; set; }
        public double? Iva { get; set; }
        public double? Req { get; set; }
        public double? Totallinea { get; set; }
        public string? Codalmacen { get; set; }
        public string? Deposito { get; set; }
        public double? Precioventa { get; set; }
        public double? Numkg { get; set; }
        public string? Supedido { get; set; }
        public int? Codcliente { get; set; }
        public double? Cargo1 { get; set; }
        public double? Cargo2 { get; set; }
        public string? Dtotexto { get; set; }
        public string? Esoferta { get; set; }
        public DateTime? Fechaentrega { get; set; }
        public int? Codenvio { get; set; }
        public double? Udmedida2 { get; set; }
        public string? Lineaoculta { get; set; }
        public int? Codformato { get; set; }
        public int? Autorizacion { get; set; }
        public string AutorizacionStr { get; set; } = null!;
        public double? Unidadestotal2 { get; set; }
        public double? Unidadesrec2 { get; set; }
        public double? Unidadespen2 { get; set; }
        public int? PColor { get; set; }
        public bool? PEditar { get; set; }
        public double? UnidadesXml { get; set; }
        public double? PrecioProveedor { get; set; }
        public double? UnidadesProveedor { get; set; }
        public double? ImporteXml { get; set; }
        public double? PrecioCaja { get; set; }
        public double? UdsR { get; set; }
        public double? UnidadesAReasignar { get; set; }
        public int? CodproveedorR { get; set; }
        public string? DescripcionXml { get; set; }
        public string? ErrorMsg { get; set; }
        public string? Proveedor { get; set; }
        public string? Nif20R { get; set; }
        public string? ProveedorR { get; set; }
        public int? CbMotivo { get; set; }
        public string? MsgMotivo { get; set; }
        public string? Umedida { get; set; }
        public string? NoIdentificacion { get; set; }
    }
}
