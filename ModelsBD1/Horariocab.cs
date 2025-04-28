using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Horariocab
    {
        public Horariocab()
        {
            Horarioempleados = new HashSet<Horarioempleado>();
            Horariolins = new HashSet<Horariolin>();
        }

        public int Codhorario { get; set; }
        public string Descripcion { get; set; } = null!;

        public virtual ICollection<Horarioempleado> Horarioempleados { get; set; }
        public virtual ICollection<Horariolin> Horariolins { get; set; }
    }
}
