using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Articulosregimene
    {
        public Articulosregimene()
        {
            Hotelesregimenes = new HashSet<Hotelesregimene>();
            Precioshoteldia = new HashSet<Precioshoteldium>();
            Codarticulos = new HashSet<Cargodtohotel>();
        }

        public int Codarticulo { get; set; }
        public bool? Alojamiento { get; set; }
        public bool? Desayuno { get; set; }
        public bool? Almuerzo { get; set; }
        public bool? Cena { get; set; }
        public double? Porcalojamiento { get; set; }
        public double? Porcdesayuno { get; set; }
        public double? Porcalmuerzo { get; set; }
        public double? Porccena { get; set; }
        public double? Porcdtonens { get; set; }
        public double? Porcdtobebes { get; set; }
        public double? Factorcalculo { get; set; }
        public byte[]? Version { get; set; }
        public int Primerservicio { get; set; }
        public int? Tarifaextras { get; set; }

        public virtual Articulo1 CodarticuloNavigation { get; set; } = null!;
        public virtual ICollection<Hotelesregimene> Hotelesregimenes { get; set; }
        public virtual ICollection<Precioshoteldium> Precioshoteldia { get; set; }

        public virtual ICollection<Cargodtohotel> Codarticulos { get; set; }
    }
}
