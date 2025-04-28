using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class VwPedcompracab
    {
        public string? Nomproveedor { get; set; }
        public string? Nif20 { get; set; }
        public string? Codalmacen { get; set; }
        public double? Totiva { get; set; }
        public double? Totreq { get; set; }
        public string Numserie { get; set; } = null!;
        public int Numpedido { get; set; }
        public string N { get; set; } = null!;
        public int? Codproveedor { get; set; }
        public string? Seriealbaran { get; set; }
        public int? Numeroalbaran { get; set; }
        public string? Nalbaran { get; set; }
        public DateTime? Fechapedido { get; set; }
        public DateTime? Fechaentrega { get; set; }
        public string? Enviopor { get; set; }
        public double? Totbruto { get; set; }
        public double? Dtopp { get; set; }
        public double? Totdtopp { get; set; }
        public double? Dtocomercial { get; set; }
        public double? Totdtocomercial { get; set; }
        public double? Totimpuestos { get; set; }
        public double? Totneto { get; set; }
        public int? Codmoneda { get; set; }
        public double? Factormoneda { get; set; }
        public string? Portespag { get; set; }
        public string? Supedido { get; set; }
        public string? Ivaincluido { get; set; }
        public string? Todorecibido { get; set; }
        public int? Tipodoc { get; set; }
        public int? Idestado { get; set; }
        public DateTime? Fechamodificado { get; set; }
        public DateTime? Hora { get; set; }
        public int? Transporte { get; set; }
        public int? Nbultos { get; set; }
        public double? Totalcargosdtos { get; set; }
        public string? Norecibido { get; set; }
        public int? Codempleado { get; set; }
        public int? Contacto { get; set; }
        public string? Frompedventacentral { get; set; }
        public DateTime? Fechacreacion { get; set; }
        public int? Numimpresiones { get; set; }
        public int? Estatus { get; set; }
        public bool Factura { get; set; }
        public bool Excel { get; set; }
        public bool EditoPedido { get; set; }
        public int? NumpedidoReasignado { get; set; }
        public int Autorizacion { get; set; }
        public int? CodvendedorRecibe { get; set; }
        public string? XmlUuid { get; set; }
        public string? PdfFileName { get; set; }
        public int Incidencia { get; set; }
        public string? Fiscal { get; set; }
        public double? MargenPu { get; set; }
        public double? MargenUds { get; set; }
        public string? IncidenciaStr { get; set; }
        public string? EstatusStr { get; set; }
        public int? CodproveedorReasignado { get; set; }
        public string? SubioDocStr { get; set; }
        public string? Almacen { get; set; }
    }
}
