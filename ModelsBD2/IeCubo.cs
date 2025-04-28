using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class IeCubo
    {
        public IeCubo()
        {
            IeControlesInformes = new HashSet<IeControlesInforme>();
            IeDimensionesCubos = new HashSet<IeDimensionesCubo>();
            IeFiltrosOrigens = new HashSet<IeFiltrosOrigen>();
            IeGruposMedida = new HashSet<IeGruposMedida>();
            IdHechoes = new HashSet<IeHecho>();
        }

        public int IdCubo { get; set; }
        public string NombreCubo { get; set; } = null!;
        public string TituloCubo { get; set; } = null!;
        public int? IdConexion { get; set; }
        public int UnidadFrecuenciaActualizacion { get; set; }
        public int CantidadFrecuenciaActualizacion { get; set; }
        public DateTime HoraActualizacion { get; set; }

        public virtual IeConexione? IdConexionNavigation { get; set; }
        public virtual ICollection<IeControlesInforme> IeControlesInformes { get; set; }
        public virtual ICollection<IeDimensionesCubo> IeDimensionesCubos { get; set; }
        public virtual ICollection<IeFiltrosOrigen> IeFiltrosOrigens { get; set; }
        public virtual ICollection<IeGruposMedida> IeGruposMedida { get; set; }

        public virtual ICollection<IeHecho> IdHechoes { get; set; }
    }
}
