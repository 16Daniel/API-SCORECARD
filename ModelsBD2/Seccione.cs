using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Seccione
    {
        public Seccione()
        {
            Familia = new HashSet<Familia>();
        }

        public int Numdpto { get; set; }
        public int Numseccion { get; set; }
        public string? Descripcion { get; set; }
        public string? Codigo { get; set; }
        public byte[]? Imagen { get; set; }
        public int? Colorfondo { get; set; }
        public int? Colortexto { get; set; }
        public string? Refteclado { get; set; }
        public byte[]? Version { get; set; }
        public string? Contrapartidacompra { get; set; }
        public string? Contrapartidaventa { get; set; }
        public string? Contrapartidacosteventas { get; set; }
        public string? Contrapartidaconsumo { get; set; }
        public string? Contrapartidadevolcompra { get; set; }
        public string? Contrapartidadevolventa { get; set; }
        public string? Contrapartidadevolcosteventa { get; set; }
        public string? Contrapartidacompradmn { get; set; }
        public string? Contrapartidaventadmn { get; set; }
        public string? Contrapartidacosteventasdmn { get; set; }
        public string? Contrapartidaconsumodmn { get; set; }
        public string? Contrapartidadevolcompradmn { get; set; }
        public string? Contrapartidadevolventadmn { get; set; }
        public string? Contrapartidadevolcosteventadm { get; set; }
        public string? Centrocoste { get; set; }
        public string? Dircontab { get; set; }
        public int? Subempresa { get; set; }
        public string? Contrapartidafaltantesinventario { get; set; }
        public string? Contrapartidasobrantesinventario { get; set; }
        public string? Contrapartidaordenesfab { get; set; }

        public virtual Departamento NumdptoNavigation { get; set; } = null!;
        public virtual ICollection<Familia> Familia { get; set; }
    }
}
