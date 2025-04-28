using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Miscubosolap
    {
        public Miscubosolap()
        {
            MiscubosolapUsuarios = new HashSet<MiscubosolapUsuario>();
        }

        public int Idcubo { get; set; }
        public int Idinforme { get; set; }
        public string Descripcion { get; set; } = null!;
        public byte[]? Dades { get; set; }
        public int? Tipo { get; set; }
        public byte[]? Metadata { get; set; }
        public int? Tipograf { get; set; }
        public int? Estilograf { get; set; }
        public int? Factgraf { get; set; }
        public string? Comparado { get; set; }

        public virtual Informe IdinformeNavigation { get; set; } = null!;
        public virtual ICollection<MiscubosolapUsuario> MiscubosolapUsuarios { get; set; }
    }
}
