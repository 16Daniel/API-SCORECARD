using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Tarifashotel
    {
        public Tarifashotel()
        {
            Cargodtohotelprecios = new HashSet<Cargodtohotelprecio>();
            Cargodtohoteltarifas = new HashSet<Cargodtohoteltarifa>();
            Dtosocupaciontemporada = new HashSet<Dtosocupaciontemporadum>();
            Hotelestarifas = new HashSet<Hotelestarifa>();
            Paqueteshotelclientes = new HashSet<Paqueteshotelcliente>();
            Precioshabitaciondia = new HashSet<Precioshabitaciondium>();
            Precioshoteldia = new HashSet<Precioshoteldium>();
            Precioshotels = new HashSet<Precioshotel>();
            Tarifashotelarticulos = new HashSet<Tarifashotelarticulo>();
            Tarifashotelcalendarios = new HashSet<Tarifashotelcalendario>();
            Tarifashotelclientes = new HashSet<Tarifashotelcliente>();
            Tarifashotelextras = new HashSet<Tarifashotelextra>();
            Tarifashotelservicios = new HashSet<Tarifashotelservicio>();
            Tarifashoteltemporada = new HashSet<Tarifashoteltemporada>();
        }

        public int Codtarifa { get; set; }
        public string? Descripcion { get; set; }
        public int? Tarifaregimen { get; set; }
        public string? Impuestosinc { get; set; }
        public byte[]? Version { get; set; }
        public int? Estanciaminima { get; set; }
        public bool? Habmasregimen { get; set; }
        public bool? Precioporpersona { get; set; }
        public short? Tiposce { get; set; }
        public short? Tipodui { get; set; }
        public int? Codgrupo { get; set; }
        public bool? Espaquete { get; set; }
        public int? Produccionpaquete { get; set; }
        public int? Codarticulopaquete { get; set; }
        public bool? Combruto { get; set; }
        public int? Estanciamaxima { get; set; }
        public string? Condiciones { get; set; }
        public bool? Imprimirdescripcion { get; set; }
        public int? Release { get; set; }
        public string? Observaciones { get; set; }
        public bool? D1 { get; set; }
        public bool? D2 { get; set; }
        public bool? D3 { get; set; }
        public bool? D4 { get; set; }
        public bool? D5 { get; set; }
        public bool? D6 { get; set; }
        public bool? D7 { get; set; }

        public virtual ICollection<Cargodtohotelprecio> Cargodtohotelprecios { get; set; }
        public virtual ICollection<Cargodtohoteltarifa> Cargodtohoteltarifas { get; set; }
        public virtual ICollection<Dtosocupaciontemporadum> Dtosocupaciontemporada { get; set; }
        public virtual ICollection<Hotelestarifa> Hotelestarifas { get; set; }
        public virtual ICollection<Paqueteshotelcliente> Paqueteshotelclientes { get; set; }
        public virtual ICollection<Precioshabitaciondium> Precioshabitaciondia { get; set; }
        public virtual ICollection<Precioshoteldium> Precioshoteldia { get; set; }
        public virtual ICollection<Precioshotel> Precioshotels { get; set; }
        public virtual ICollection<Tarifashotelarticulo> Tarifashotelarticulos { get; set; }
        public virtual ICollection<Tarifashotelcalendario> Tarifashotelcalendarios { get; set; }
        public virtual ICollection<Tarifashotelcliente> Tarifashotelclientes { get; set; }
        public virtual ICollection<Tarifashotelextra> Tarifashotelextras { get; set; }
        public virtual ICollection<Tarifashotelservicio> Tarifashotelservicios { get; set; }
        public virtual ICollection<Tarifashoteltemporada> Tarifashoteltemporada { get; set; }
    }
}
