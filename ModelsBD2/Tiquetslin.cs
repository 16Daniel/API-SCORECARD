using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Tiquetslin
    {
        public Tiquetslin()
        {
            Tiquetsconsumos = new HashSet<Tiquetsconsumo>();
            Tiquetsmodifs = new HashSet<Tiquetsmodif>();
        }

        public short Fo { get; set; }
        public string Serie { get; set; } = null!;
        public int Numero { get; set; }
        public string N { get; set; } = null!;
        public int Numlinea { get; set; }
        public int? Codarticulo { get; set; }
        public string? Descripcion { get; set; }
        public double? Coste { get; set; }
        public double? Unidades { get; set; }
        public double? Precio { get; set; }
        public double? Precioiva { get; set; }
        public double? Preciodefecto { get; set; }
        public double? Codvendedor { get; set; }
        public int? Codformato { get; set; }
        public int? Codmacro { get; set; }
        public string? Tipo { get; set; }
        public short? Tipoiva { get; set; }
        public double? Dto { get; set; }
        public string? Referencia { get; set; }

        public virtual Ticketscab Ticketscab { get; set; } = null!;
        public virtual Tiquetscab Tiquetscab { get; set; } = null!;
        public virtual ICollection<Tiquetsconsumo> Tiquetsconsumos { get; set; }
        public virtual ICollection<Tiquetsmodif> Tiquetsmodifs { get; set; }
    }
}
