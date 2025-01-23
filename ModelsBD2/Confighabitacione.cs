using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Confighabitacione
    {
        public int Idhotel { get; set; }
        public short Planta { get; set; }
        public short Numobjeto { get; set; }
        public short? Tipoobjeto { get; set; }
        public short? Posx { get; set; }
        public short? Posy { get; set; }
        public int? Nummesa { get; set; }
        public int? Codarticulo { get; set; }
        public bool? Eshabitacion { get; set; }
        public string? Nombrehabitacion { get; set; }
        public short? Tarifa { get; set; }
        public double? Cargo { get; set; }
        public string? Opciones { get; set; }
        public int? Extension { get; set; }
        public string? Caracteristicas { get; set; }
        public string? Codalmacen { get; set; }
        public int? Codvendedor { get; set; }
        public string? Unidadasociada { get; set; }
        public int? Prioridad { get; set; }

        public virtual Planta PlantaNavigation { get; set; } = null!;
    }
}
