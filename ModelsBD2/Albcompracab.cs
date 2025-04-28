using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Albcompracab
    {
        public Albcompracab()
        {
            Albcompradtos = new HashSet<Albcompradto>();
            Albcompralinamortizacions = new HashSet<Albcompralinamortizacion>();
            Albcompralins = new HashSet<Albcompralin>();
            Albcompratots = new HashSet<Albcompratot>();
        }

        public string Numserie { get; set; } = null!;
        public int Numalbaran { get; set; }
        public string N { get; set; } = null!;
        public string? Sualbaran { get; set; }
        public string? Facturado { get; set; }
        public string? Numseriefac { get; set; }
        public int? Numfac { get; set; }
        public string? Nfac { get; set; }
        public string? Esundeposito { get; set; }
        public string? Esdevolucion { get; set; }
        public int? Codproveedor { get; set; }
        public DateTime? Fechaalbaran { get; set; }
        public string? Enviopor { get; set; }
        public string? Portespag { get; set; }
        public double? Dtocomercial { get; set; }
        public double? Totdtocomercial { get; set; }
        public double? Dtopp { get; set; }
        public double? Totdtopp { get; set; }
        public double? Totalbruto { get; set; }
        public double? Totalimpuestos { get; set; }
        public double? Totalneto { get; set; }
        public string? Seleccionado { get; set; }
        public int? Codmoneda { get; set; }
        public double? Factormoneda { get; set; }
        public string? Ivaincluido { get; set; }
        public DateTime? Fechaentrada { get; set; }
        public int? Tipodoc { get; set; }
        public int? Tipodocfac { get; set; }
        public int? Idestado { get; set; }
        public DateTime? Fechamodificado { get; set; }
        public DateTime? Hora { get; set; }
        public int? Transporte { get; set; }
        public int? Nbultos { get; set; }
        public double? Totalcargosdtos { get; set; }
        public int? Codcliente { get; set; }
        public string? Chequeado { get; set; }
        public string? Norecibido { get; set; }
        public DateTime? Fechaalbaranventa { get; set; }
        public DateTime? Fechacreacion { get; set; }
        public int? Numimpresiones { get; set; }

        public virtual Proveedore? CodproveedorNavigation { get; set; }
        public virtual Albcompracamposlibre? Albcompracamposlibre { get; set; }
        public virtual Albcomprafirma? Albcomprafirma { get; set; }
        public virtual ICollection<Albcompradto> Albcompradtos { get; set; }
        public virtual ICollection<Albcompralinamortizacion> Albcompralinamortizacions { get; set; }
        public virtual ICollection<Albcompralin> Albcompralins { get; set; }
        public virtual ICollection<Albcompratot> Albcompratots { get; set; }
    }
}
