using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Presupuestoscab
    {
        public Presupuestoscab()
        {
            Presupuestosdtos = new HashSet<Presupuestosdto>();
            Presupuestoslins = new HashSet<Presupuestoslin>();
            Presupuestospartida = new HashSet<Presupuestospartida>();
            Presupuestostots = new HashSet<Presupuestostot>();
        }

        public string Numserie { get; set; } = null!;
        public int Numpresupuesto { get; set; }
        public string N { get; set; } = null!;
        public int Version { get; set; }
        public int? Codcliente { get; set; }
        public DateTime? Fecha { get; set; }
        public DateTime? Hora { get; set; }
        public double? Totbruto { get; set; }
        public double? Dtocomercial { get; set; }
        public double? Totdtocomercial { get; set; }
        public double? Dtopp { get; set; }
        public double? Totdtopp { get; set; }
        public double? Totimpuestos { get; set; }
        public double? Totneto { get; set; }
        public double? Totalcoste { get; set; }
        public int? Codmoneda { get; set; }
        public double? Factormoneda { get; set; }
        public int? Codvendedor { get; set; }
        public int? Codtarifa { get; set; }
        public string? Ivaincluido { get; set; }
        public int? Idestado { get; set; }
        public DateTime? Fechamodificado { get; set; }
        public int? Contacto { get; set; }
        public int? Tipodoc { get; set; }
        public int? Z { get; set; }
        public string? Caja { get; set; }
        public double? Totalcosteiva { get; set; }
        public double? Totalcargosdtos { get; set; }
        public int? Numrollo { get; set; }
        public string? Serieasunto { get; set; }
        public int? Numeroasunto { get; set; }
        public string? Supresupuesto { get; set; }

        public virtual Presupuestoscamposlibre? Presupuestoscamposlibre { get; set; }
        public virtual ICollection<Presupuestosdto> Presupuestosdtos { get; set; }
        public virtual ICollection<Presupuestoslin> Presupuestoslins { get; set; }
        public virtual ICollection<Presupuestospartida> Presupuestospartida { get; set; }
        public virtual ICollection<Presupuestostot> Presupuestostots { get; set; }
    }
}
