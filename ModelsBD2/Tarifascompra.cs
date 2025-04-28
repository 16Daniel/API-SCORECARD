using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Tarifascompra
    {
        public Tarifascompra()
        {
            Clientestarifascompras = new HashSet<Clientestarifascompra>();
            Condicionesproveedors = new HashSet<Condicionesproveedor>();
            Precioscompras = new HashSet<Precioscompra>();
            Codalmacens = new HashSet<Almacen>();
        }

        public int Codproveedor { get; set; }
        public int Idtarifac { get; set; }
        public string? Descripcion { get; set; }
        public DateTime? Fechaini { get; set; }
        public DateTime? Fechafin { get; set; }
        public string? Coniva { get; set; }
        public int? Codmoneda { get; set; }
        public int? Posicion { get; set; }

        public virtual Proveedore CodproveedorNavigation { get; set; } = null!;
        public virtual ICollection<Clientestarifascompra> Clientestarifascompras { get; set; }
        public virtual ICollection<Condicionesproveedor> Condicionesproveedors { get; set; }
        public virtual ICollection<Precioscompra> Precioscompras { get; set; }

        public virtual ICollection<Almacen> Codalmacens { get; set; }
    }
}
