using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Facturasventum
    {
        public Facturasventum()
        {
            Facturasventadtos = new HashSet<Facturasventadto>();
            Facturasventahotels = new HashSet<Facturasventahotel>();
            Facturasventanota = new HashSet<Facturasventanota>();
            Facturasventapromociones = new HashSet<Facturasventapromocione>();
            Facturasventarets = new HashSet<Facturasventaret>();
            Facturasventaseriesresols = new HashSet<Facturasventaseriesresol>();
            Facturasventatots = new HashSet<Facturasventatot>();
            Tiquetsfacturados = new HashSet<Tiquetsfacturado>();
        }

        public string Numserie { get; set; } = null!;
        public int Numfactura { get; set; }
        public string N { get; set; } = null!;
        public int? Codcliente { get; set; }
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
        public double? Totalcoste { get; set; }
        public int? Codmoneda { get; set; }
        public double? Factormoneda { get; set; }
        public string? Ivaincluido { get; set; }
        public string? Traspasada { get; set; }
        public DateTime? Fechatraspaso { get; set; }
        public short? EnlaceEjercicio { get; set; }
        public short? EnlaceEmpresa { get; set; }
        public string? EnlaceUsuario { get; set; }
        public int? EnlaceAsiento { get; set; }
        public int? Codvendedor { get; set; }
        public string? Vienedefo { get; set; }
        public DateTime? Fechaentrada { get; set; }
        public int? Tipodoc { get; set; }
        public int? Idestado { get; set; }
        public DateTime? Fechamodificado { get; set; }
        public int? Z { get; set; }
        public string? Caja { get; set; }
        public double? Totalcosteiva { get; set; }
        public double Entregado { get; set; }
        public double Cambio { get; set; }
        public double Propina { get; set; }
        public int? Codenvio { get; set; }
        public int? Transporte { get; set; }
        public double? Totalcargosdtos { get; set; }
        public int? Numrollo { get; set; }
        public int? Vendedormodificado { get; set; }
        public double? Totalretencion { get; set; }
        public string? Sufactura { get; set; }
        public bool? Esinversion { get; set; }
        public DateTime? Fechacreacion { get; set; }
        public int? Idmotivodto { get; set; }
        public int Numimpresiones { get; set; }
        public string? Cleancashcontrolcode1 { get; set; }
        public string? Cleancashcontrolcode2 { get; set; }
        public int? Agrupacion { get; set; }
        public string? Esentregaacuenta { get; set; }
        public string? Regimfact { get; set; }

        public virtual Facturasventacamposlibre? Facturasventacamposlibre { get; set; }
        public virtual Facturasventacliente? Facturasventacliente { get; set; }
        public virtual Facturasventafirma? Facturasventafirma { get; set; }
        public virtual ICollection<Facturasventadto> Facturasventadtos { get; set; }
        public virtual ICollection<Facturasventahotel> Facturasventahotels { get; set; }
        public virtual ICollection<Facturasventanota> Facturasventanota { get; set; }
        public virtual ICollection<Facturasventapromocione> Facturasventapromociones { get; set; }
        public virtual ICollection<Facturasventaret> Facturasventarets { get; set; }
        public virtual ICollection<Facturasventaseriesresol> Facturasventaseriesresols { get; set; }
        public virtual ICollection<Facturasventatot> Facturasventatots { get; set; }
        public virtual ICollection<Tiquetsfacturado> Tiquetsfacturados { get; set; }
    }
}
