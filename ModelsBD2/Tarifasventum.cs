using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Tarifasventum
    {
        public Tarifasventum()
        {
            Dtostarifas = new HashSet<Dtostarifa>();
            Hotelestarifascargos = new HashSet<Hotelestarifascargo>();
            Hotelestarifasextras = new HashSet<Hotelestarifasextra>();
            Preciosventa = new HashSet<Preciosventum>();
            Tarifasclientedmns = new HashSet<Tarifasclientedmn>();
            Tarifasclientes = new HashSet<Tarifascliente>();
            Tarifasventagruposalmacens = new HashSet<Tarifasventagruposalmacen>();
            Tarifasventareglas = new HashSet<Tarifasventaregla>();
            IdTienda = new HashSet<NetTiendum>();
        }

        public int Idtarifav { get; set; }
        public string? Descripcion { get; set; }
        public DateTime? Fechaini { get; set; }
        public DateTime? Fechafin { get; set; }
        public string? Coniva { get; set; }
        public int? Tarifaalternativa { get; set; }
        public string? Descripalternativa { get; set; }
        public int? Codmoneda { get; set; }
        public int? Idtarifabase { get; set; }
        public string? Almacencostes { get; set; }
        public int? Visibilidad { get; set; }
        public string? Actualizarremfronts { get; set; }
        public string? Automatica { get; set; }

        public virtual ICollection<Dtostarifa> Dtostarifas { get; set; }
        public virtual ICollection<Hotelestarifascargo> Hotelestarifascargos { get; set; }
        public virtual ICollection<Hotelestarifasextra> Hotelestarifasextras { get; set; }
        public virtual ICollection<Preciosventum> Preciosventa { get; set; }
        public virtual ICollection<Tarifasclientedmn> Tarifasclientedmns { get; set; }
        public virtual ICollection<Tarifascliente> Tarifasclientes { get; set; }
        public virtual ICollection<Tarifasventagruposalmacen> Tarifasventagruposalmacens { get; set; }
        public virtual ICollection<Tarifasventaregla> Tarifasventareglas { get; set; }

        public virtual ICollection<NetTiendum> IdTienda { get; set; }
    }
}
