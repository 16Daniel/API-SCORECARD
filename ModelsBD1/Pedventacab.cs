using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Pedventacab
    {
        public Pedventacab()
        {
            Pedventaconsumos = new HashSet<Pedventaconsumo>();
            Pedventacupones = new HashSet<Pedventacupone>();
            Pedventacuponesgenerados = new HashSet<Pedventacuponesgenerado>();
            Pedventadtos = new HashSet<Pedventadto>();
            Pedventalins = new HashSet<Pedventalin>();
            Pedventamodifs = new HashSet<Pedventamodif>();
            Pedventapromociones = new HashSet<Pedventapromocione>();
            Pedventatots = new HashSet<Pedventatot>();
        }

        public string Numserie { get; set; } = null!;
        public int Numpedido { get; set; }
        public string N { get; set; } = null!;
        public string? Supedido { get; set; }
        public string? Seriealbaran { get; set; }
        public int? Numeroalbaran { get; set; }
        public string? Nalbaran { get; set; }
        public int? Codcliente { get; set; }
        public DateTime? Fechapedido { get; set; }
        public DateTime? Fechaentrega { get; set; }
        public string? Enviopor { get; set; }
        public string? Portespag { get; set; }
        public double? Totbruto { get; set; }
        public double? Dtocomercial { get; set; }
        public double? Totdtocomercial { get; set; }
        public double? Dtopp { get; set; }
        public double? Totdtopp { get; set; }
        public double? Totimpuestos { get; set; }
        public double? Totneto { get; set; }
        public double? Totalcoste { get; set; }
        public double? Codmoneda { get; set; }
        public double? Factormoneda { get; set; }
        public int? Codvendedor { get; set; }
        public string? Ivaincluido { get; set; }
        public int? Codtarifa { get; set; }
        public string? Todorecibido { get; set; }
        public int? Contacto { get; set; }
        public int? Tipodoc { get; set; }
        public int? Idestado { get; set; }
        public DateTime? Fechamodificado { get; set; }
        public int? Z { get; set; }
        public string? Caja { get; set; }
        public double? Totalcosteiva { get; set; }
        public DateTime? Hora { get; set; }
        public double? Impgastoscancel { get; set; }
        public string? Observreserva { get; set; }
        public int? Nbultos { get; set; }
        public int? Transporte { get; set; }
        public int? Codenvio { get; set; }
        public string? Condentrega { get; set; }
        public string? Condentregaedi { get; set; }
        public double? Totalcargosdtos { get; set; }
        public int? Numrollo { get; set; }
        public string? Norecibido { get; set; }
        public DateTime? Horaentrega { get; set; }
        public int? Tiporeserva { get; set; }
        public int? Estadoreserva { get; set; }
        public DateTime? Fechacreacion { get; set; }
        public int Numimpresiones { get; set; }

        public virtual Pedventacamposlibre? Pedventacamposlibre { get; set; }
        public virtual Pedventafirma? Pedventafirma { get; set; }
        public virtual ICollection<Pedventaconsumo> Pedventaconsumos { get; set; }
        public virtual ICollection<Pedventacupone> Pedventacupones { get; set; }
        public virtual ICollection<Pedventacuponesgenerado> Pedventacuponesgenerados { get; set; }
        public virtual ICollection<Pedventadto> Pedventadtos { get; set; }
        public virtual ICollection<Pedventalin> Pedventalins { get; set; }
        public virtual ICollection<Pedventamodif> Pedventamodifs { get; set; }
        public virtual ICollection<Pedventapromocione> Pedventapromociones { get; set; }
        public virtual ICollection<Pedventatot> Pedventatots { get; set; }
    }
}
