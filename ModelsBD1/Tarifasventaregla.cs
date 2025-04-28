using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Tarifasventaregla
    {
        public int Idtarifav { get; set; }
        public int Posicion { get; set; }
        public int? Idgrupo { get; set; }
        public int? Origen { get; set; }
        public int? Origentarifa { get; set; }
        public int? Origentipocoste { get; set; }
        public string? Origencostealmacen { get; set; }
        public int? Comomodificarprecio { get; set; }
        public double? Comomodificarpreciovalor { get; set; }
        public double? Comomodificarpreciovalor2 { get; set; }
        public int? Actuasobre { get; set; }
        public int? Redondeo { get; set; }
        public string? Mascararedondeo { get; set; }
        public int? Aproximacion { get; set; }
        public int? Alcambiarprecioneto { get; set; }
        public string? Copiarfromporcdefecto { get; set; }
        public string? Copiarfromporcdefecto2 { get; set; }
        public long? Versionregla { get; set; }
        public DateTime? Fechaofertadesde { get; set; }
        public DateTime? Fechaofertahasta { get; set; }

        public virtual Tarifasventum IdtarifavNavigation { get; set; } = null!;
    }
}
