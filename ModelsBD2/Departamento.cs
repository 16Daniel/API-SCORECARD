using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Departamento
    {
        public Departamento()
        {
            Departamentoidiomas = new HashSet<Departamentoidioma>();
            Secciones = new HashSet<Seccione>();
        }

        public int Numdpto { get; set; }
        public string? Descripcion { get; set; }
        public byte[]? Imagen { get; set; }
        public byte[]? Version { get; set; }
        public string? Centrocoste { get; set; }

        public virtual ICollection<Departamentoidioma> Departamentoidiomas { get; set; }
        public virtual ICollection<Seccione> Secciones { get; set; }
    }
}
