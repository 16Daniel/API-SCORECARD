using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Articuloshabitacione
    {
        public Articuloshabitacione()
        {
            Articuloshabitacionespaxwebs = new HashSet<Articuloshabitacionespaxweb>();
            Hoteleshabitaciones = new HashSet<Hoteleshabitacione>();
            Hoteleshabitacioneswebs = new HashSet<Hoteleshabitacionesweb>();
            Precioshoteldia = new HashSet<Precioshoteldium>();
            Codarticulos = new HashSet<Cargodtohotel>();
        }

        public int Codarticulo { get; set; }
        public bool Precioporhabitacion { get; set; }
        public int? Paxdefecto { get; set; }
        public int? Paxnens { get; set; }
        public int? Paxbebes { get; set; }
        public double? Factorcalculo { get; set; }
        public double? Suplpax { get; set; }
        public double? Suplpaxnen { get; set; }
        public double? Suplpaxbebe { get; set; }
        public double? Dtoregpax { get; set; }
        public double? Dtoregpaxnen { get; set; }
        public double? Dtoregpaxbebe { get; set; }
        public byte[]? Version { get; set; }
        public int Codarticulotot { get; set; }

        public virtual Articulo1 CodarticuloNavigation { get; set; } = null!;
        public virtual ICollection<Articuloshabitacionespaxweb> Articuloshabitacionespaxwebs { get; set; }
        public virtual ICollection<Hoteleshabitacione> Hoteleshabitaciones { get; set; }
        public virtual ICollection<Hoteleshabitacionesweb> Hoteleshabitacioneswebs { get; set; }
        public virtual ICollection<Precioshoteldium> Precioshoteldia { get; set; }

        public virtual ICollection<Cargodtohotel> Codarticulos { get; set; }
    }
}
