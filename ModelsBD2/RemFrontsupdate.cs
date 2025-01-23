using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class RemFrontsupdate
    {
        public RemFrontsupdate()
        {
            RemFrontsupdatelins = new HashSet<RemFrontsupdatelin>();
        }

        public int Idupdate { get; set; }
        public int? Idfront { get; set; }
        public string? Nombreterminal { get; set; }
        public string? Siglas { get; set; }
        public int? Versionbd { get; set; }
        public int? Majorversionexe { get; set; }
        public int? Minorversionexe { get; set; }
        public DateTime? Fecha { get; set; }
        public DateTime? Hora { get; set; }
        public string? Basedatos { get; set; }
        public string? Ok { get; set; }
        public int? Tipobd { get; set; }

        public virtual ICollection<RemFrontsupdatelin> RemFrontsupdatelins { get; set; }
    }
}
