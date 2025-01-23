using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Facturascompra
    {
        public Facturascompra()
        {
            Facturascompracuenta = new HashSet<Facturascompracuenta>();
            Facturascompradtos = new HashSet<Facturascompradto>();
            Facturascomprarets = new HashSet<Facturascompraret>();
            Facturascompraseriesresols = new HashSet<Facturascompraseriesresol>();
            Facturascompratots = new HashSet<Facturascompratot>();
        }

        public string Numserie { get; set; } = null!;
        public int Numfactura { get; set; }
        public string N { get; set; } = null!;
        public string? Sufactura { get; set; }
        public int? Codproveedor { get; set; }
        public DateTime? Fecha { get; set; }
        public DateTime? Hora { get; set; }
        public string? Enviopor { get; set; }
        public string? Portespag { get; set; }
        public double? Dtocomercial { get; set; }
        public double? Totdtocomercial { get; set; }
        public double? Dtopp { get; set; }
        public double? Totdtopp { get; set; }
        public double? Totalbruto { get; set; }
        public double? Totalimpuestos { get; set; }
        public double? Totalneto { get; set; }
        public int? Codmoneda { get; set; }
        public double? Factormoneda { get; set; }
        public string? Traspasado { get; set; }
        public string? Ivaincluido { get; set; }
        public DateTime? Fechatraspaso { get; set; }
        public short? EnlaceEjercicio { get; set; }
        public short? EnlaceEmpresa { get; set; }
        public string? EnlaceUsuario { get; set; }
        public int? EnlaceAsiento { get; set; }
        public DateTime? Fechaentrada { get; set; }
        public int? Tipodoc { get; set; }
        public int? Idestado { get; set; }
        public DateTime? Fechamodificado { get; set; }
        public int? Transporte { get; set; }
        public double? Totalcargosdtos { get; set; }
        public int? Usuariodescuadre { get; set; }
        public DateTime? Fechasufactura { get; set; }
        public double? Totalretencion { get; set; }
        public bool? Esinversion { get; set; }
        public DateTime? Fechacreacion { get; set; }
        public int? Numimpresiones { get; set; }
        public string? Esentregaacuenta { get; set; }
        public string? Regimfact { get; set; }

        public virtual Facturascompracamposlibre? Facturascompracamposlibre { get; set; }
        public virtual Facturascompracomprobanteret? Facturascompracomprobanteret { get; set; }
        public virtual Facturascomprafirma? Facturascomprafirma { get; set; }
        public virtual ICollection<Facturascompracuenta> Facturascompracuenta { get; set; }
        public virtual ICollection<Facturascompradto> Facturascompradtos { get; set; }
        public virtual ICollection<Facturascompraret> Facturascomprarets { get; set; }
        public virtual ICollection<Facturascompraseriesresol> Facturascompraseriesresols { get; set; }
        public virtual ICollection<Facturascompratot> Facturascompratots { get; set; }
    }
}
