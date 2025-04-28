using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class RemConfigsala
    {
        public int Idfront { get; set; }
        public short Sala { get; set; }
        public short Numobjeto { get; set; }
        public short? Tipoobjeto { get; set; }
        public short? Posx { get; set; }
        public short? Posy { get; set; }
        public short? Nummesa { get; set; }
        public int? Tarifa { get; set; }
        public double? Cargo { get; set; }
        public short? Numcomensales { get; set; }
        public string? Tasaespecial { get; set; }
        public string? Opciones { get; set; }
        public string? Imptiquets { get; set; }
        public string? Impfacturas { get; set; }
        public double? Propinadef { get; set; }
        public int? Codartconsummin { get; set; }
        public double? Importeconsummin { get; set; }
        public int? Tiposervicio { get; set; }
        public double? Consumomax { get; set; }
        public short? Nummesareal { get; set; }

        public virtual RemSala RemSala { get; set; } = null!;
    }
}
