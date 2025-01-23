using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Turno
    {
        public Turno()
        {
            Favoritosturnos = new HashSet<Favoritosturno>();
            Turnosarticulosdefectos = new HashSet<Turnosarticulosdefecto>();
            Codarticulos = new HashSet<Articulo1>();
        }

        public int Codturno { get; set; }
        public string? Descripcion { get; set; }
        public byte[]? Version { get; set; }
        public int? Tarifabarras { get; set; }
        public int? Tarifamesas { get; set; }
        public string? Mostrarfamilias { get; set; }
        public int? Configimpauto { get; set; }
        public string? Opciones { get; set; }
        public int? Tarifavdirecta { get; set; }
        public int? Tarifadelivery { get; set; }
        public int? Configimpautotelec { get; set; }

        public virtual ICollection<Favoritosturno> Favoritosturnos { get; set; }
        public virtual ICollection<Turnosarticulosdefecto> Turnosarticulosdefectos { get; set; }

        public virtual ICollection<Articulo1> Codarticulos { get; set; }
    }
}
