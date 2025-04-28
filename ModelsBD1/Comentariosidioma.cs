using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Comentariosidioma
    {
        public int Codcomentario { get; set; }
        public int Codidioma { get; set; }
        public string? Descripcion { get; set; }

        public virtual Comentario CodcomentarioNavigation { get; set; } = null!;
        public virtual Idioma CodidiomaNavigation { get; set; } = null!;
    }
}
