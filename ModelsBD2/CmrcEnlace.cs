using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class CmrcEnlace
    {
        public CmrcEnlace()
        {
            CmrcEnlacesidiomas = new HashSet<CmrcEnlacesidioma>();
        }

        public int Idenlace { get; set; }
        public int? Idenlacepadre { get; set; }
        public int Nivel { get; set; }
        public int Posicion { get; set; }
        public string? Titulo { get; set; }
        public int? Tipo { get; set; }
        public string? Url { get; set; }
        public bool? Nuevaventana { get; set; }
        public bool? Identificacion { get; set; }

        public virtual ICollection<CmrcEnlacesidioma> CmrcEnlacesidiomas { get; set; }
    }
}
