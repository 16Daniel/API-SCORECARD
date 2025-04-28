using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Cargodtohotel
    {
        public Cargodtohotel()
        {
            Cargodtohotelprecios = new HashSet<Cargodtohotelprecio>();
            Codhabitacions = new HashSet<Articuloshabitacione>();
            Codregimen = new HashSet<Articulosregimene>();
        }

        public int Codarticulo { get; set; }
        public bool Adulto { get; set; }
        public bool Nen { get; set; }
        public bool Bebe { get; set; }
        public bool Habitacion { get; set; }
        public bool Alojamiento { get; set; }
        public bool Regimen { get; set; }
        public short Aplicaren { get; set; }
        public bool Sinagencia { get; set; }
        public DateTime? Fechaentradadesde { get; set; }
        public DateTime? Fechaentradahasta { get; set; }
        public DateTime? Fechaestanciadesde { get; set; }
        public DateTime? Fechaestanciahasta { get; set; }
        public bool D1 { get; set; }
        public bool D2 { get; set; }
        public bool D3 { get; set; }
        public bool D4 { get; set; }
        public bool D5 { get; set; }
        public bool D6 { get; set; }
        public bool D7 { get; set; }
        public DateTime? Fechareservadesde { get; set; }
        public DateTime? Fechareservahasta { get; set; }
        public short Diasantelacion { get; set; }
        public short Minpaxadulto { get; set; }
        public short Minpaxnen { get; set; }
        public short Minpaxbebe { get; set; }
        public short Numnoches { get; set; }
        public short Minunidades { get; set; }
        public bool Porcentaje { get; set; }
        public bool Importe { get; set; }
        public bool Diagratis { get; set; }
        public bool Habitaciongratis { get; set; }
        public bool? Aplicarsiempre { get; set; }
        public bool? Acumulable { get; set; }
        public double Valor { get; set; }
        public int Valorx { get; set; }
        public int Posicion { get; set; }
        public bool Conagencia { get; set; }
        public int? Numnochesmax { get; set; }
        public byte[] Version { get; set; } = null!;
        public int? Edadmin { get; set; }
        public int? Edadmax { get; set; }
        public bool Extras { get; set; }
        public string? Observaciones { get; set; }
        public bool? Aplicarsintarifa { get; set; }
        public bool Aplicarahabitacion { get; set; }
        public bool Impuestosincluidos { get; set; }

        public virtual Articulo1 CodarticuloNavigation { get; set; } = null!;
        public virtual ICollection<Cargodtohotelprecio> Cargodtohotelprecios { get; set; }

        public virtual ICollection<Articuloshabitacione> Codhabitacions { get; set; }
        public virtual ICollection<Articulosregimene> Codregimen { get; set; }
    }
}
