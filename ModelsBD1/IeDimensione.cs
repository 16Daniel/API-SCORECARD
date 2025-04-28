using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class IeDimensione
    {
        public IeDimensione()
        {
            IeAtributos = new HashSet<IeAtributo>();
            IeDimensionesCubos = new HashSet<IeDimensionesCubo>();
            IeJerarquia = new HashSet<IeJerarquia>();
        }

        public int IdDimension { get; set; }
        public string NameDimension { get; set; } = null!;
        public string TablasOrigen { get; set; } = null!;
        public string SqlTablasOrigen { get; set; } = null!;
        public bool? Visible { get; set; }
        public bool EsDimensionTiempo { get; set; }
        public string? IdTitulo { get; set; }
        public string? IdTituloVacio { get; set; }
        public string? IdTituloTodos { get; set; }

        public virtual ICollection<IeAtributo> IeAtributos { get; set; }
        public virtual ICollection<IeDimensionesCubo> IeDimensionesCubos { get; set; }
        public virtual ICollection<IeJerarquia> IeJerarquia { get; set; }
    }
}
