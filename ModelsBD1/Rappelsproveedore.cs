using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Rappelsproveedore
    {
        public Rappelsproveedore()
        {
            Condicionesrappelsproveedors = new HashSet<Condicionesrappelsproveedor>();
            Intervalosrappels = new HashSet<Intervalosrappel>();
        }

        public int Codproveedor { get; set; }
        public int Codrappel { get; set; }
        public string? Nomrappel { get; set; }
        public string? Siglas { get; set; }
        public DateTime? Fechaini { get; set; }
        public DateTime? Fechafin { get; set; }
        public DateTime? Fechacobro { get; set; }
        public string? Facturacion { get; set; }
        public double? Importecompra { get; set; }
        public double? Importerappel { get; set; }
        public string? Rappelpor { get; set; }
        public string? Porcimporte { get; set; }
        public int? Numconcepto { get; set; }
        public string? Ivaincluido { get; set; }
        public double? Udscompra { get; set; }
        public int? Codartrappel { get; set; }
        public string? Tallarappel { get; set; }
        public string? Colorrappel { get; set; }

        public virtual Proveedore CodproveedorNavigation { get; set; } = null!;
        public virtual ICollection<Condicionesrappelsproveedor> Condicionesrappelsproveedors { get; set; }
        public virtual ICollection<Intervalosrappel> Intervalosrappels { get; set; }
    }
}
