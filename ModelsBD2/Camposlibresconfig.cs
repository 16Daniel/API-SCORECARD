using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Camposlibresconfig
    {
        public Camposlibresconfig()
        {
            Camposlibresporsubtipos = new HashSet<Camposlibresporsubtipo>();
            Camposlibresposibles = new HashSet<Camposlibresposible>();
        }

        public short Tabla { get; set; }
        public string Campo { get; set; } = null!;
        public string Etiqueta { get; set; } = null!;
        public short? Posicion { get; set; }
        public short? Tipo { get; set; }
        public short? Tamany { get; set; }
        public short? Tipovalor { get; set; }
        public short? TablaRelacion { get; set; }
        public string? CampoRelacion { get; set; }
        public string? Valordefecto { get; set; }
        public string? ValorMinimo { get; set; }
        public string? ValorMaximo { get; set; }
        public string? Tablafisica { get; set; }
        public string? Campofisico { get; set; }
        public bool Obligatorio { get; set; }
        public bool AvisarVacio { get; set; }

        public virtual ICollection<Camposlibresporsubtipo> Camposlibresporsubtipos { get; set; }
        public virtual ICollection<Camposlibresposible> Camposlibresposibles { get; set; }
    }
}
