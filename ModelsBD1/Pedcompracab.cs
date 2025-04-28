using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Pedcompracab
    {
        public Pedcompracab()
        {
            Pedcompradtos = new HashSet<Pedcompradto>();
            Pedcompralins = new HashSet<Pedcompralin>();
            Pedcompratots = new HashSet<Pedcompratot>();
        }

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

        public virtual Pedcompracamposlibre? Pedcompracamposlibre { get; set; }
        public virtual Pedcomprafirma? Pedcomprafirma { get; set; }
        public virtual ICollection<Pedcompradto> Pedcompradtos { get; set; }
        public virtual ICollection<Pedcompralin> Pedcompralins { get; set; }
        public virtual ICollection<Pedcompratot> Pedcompratots { get; set; }
    }
}
