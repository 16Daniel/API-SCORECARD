using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class ShowPresentacione
    {
        public ShowPresentacione()
        {
            ShowDiapositivaspresentacions = new HashSet<ShowDiapositivaspresentacion>();
            ShowPresentacionhorarioIddomingoNavigations = new HashSet<ShowPresentacionhorario>();
            ShowPresentacionhorarioIdjuevesNavigations = new HashSet<ShowPresentacionhorario>();
            ShowPresentacionhorarioIdlunesNavigations = new HashSet<ShowPresentacionhorario>();
            ShowPresentacionhorarioIdmartesNavigations = new HashSet<ShowPresentacionhorario>();
            ShowPresentacionhorarioIdmiercolesNavigations = new HashSet<ShowPresentacionhorario>();
            ShowPresentacionhorarioIdsabadoNavigations = new HashSet<ShowPresentacionhorario>();
            ShowPresentacionhorarioIdviernesNavigations = new HashSet<ShowPresentacionhorario>();
        }

        public int Idpresentacion { get; set; }
        public string? Nombre { get; set; }
        public int? Ancho { get; set; }
        public int? Alto { get; set; }
        public bool? Mostrarvisor { get; set; }
        public byte[]? Version { get; set; }
        public bool? Barrasuperior { get; set; }
        public bool? Reescalar { get; set; }

        public virtual ICollection<ShowDiapositivaspresentacion> ShowDiapositivaspresentacions { get; set; }
        public virtual ICollection<ShowPresentacionhorario> ShowPresentacionhorarioIddomingoNavigations { get; set; }
        public virtual ICollection<ShowPresentacionhorario> ShowPresentacionhorarioIdjuevesNavigations { get; set; }
        public virtual ICollection<ShowPresentacionhorario> ShowPresentacionhorarioIdlunesNavigations { get; set; }
        public virtual ICollection<ShowPresentacionhorario> ShowPresentacionhorarioIdmartesNavigations { get; set; }
        public virtual ICollection<ShowPresentacionhorario> ShowPresentacionhorarioIdmiercolesNavigations { get; set; }
        public virtual ICollection<ShowPresentacionhorario> ShowPresentacionhorarioIdsabadoNavigations { get; set; }
        public virtual ICollection<ShowPresentacionhorario> ShowPresentacionhorarioIdviernesNavigations { get; set; }
    }
}
