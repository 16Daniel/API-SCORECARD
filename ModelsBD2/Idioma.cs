using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Idioma
    {
        public Idioma()
        {
            Comentariosidiomas = new HashSet<Comentariosidioma>();
            Departamentoidiomas = new HashSet<Departamentoidioma>();
            Favoritosidiomas = new HashSet<Favoritosidioma>();
            Formatosidiomas = new HashSet<Formatosidioma>();
            Modificadoresidiomas = new HashSet<Modificadoresidioma>();
        }

        public int Codidioma { get; set; }
        public string? Descripcion { get; set; }
        public string? Codiso6391 { get; set; }
        public byte[]? Version { get; set; }

        public virtual ICollection<Comentariosidioma> Comentariosidiomas { get; set; }
        public virtual ICollection<Departamentoidioma> Departamentoidiomas { get; set; }
        public virtual ICollection<Favoritosidioma> Favoritosidiomas { get; set; }
        public virtual ICollection<Formatosidioma> Formatosidiomas { get; set; }
        public virtual ICollection<Modificadoresidioma> Modificadoresidiomas { get; set; }
    }
}
