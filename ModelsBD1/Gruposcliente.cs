using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Gruposcliente
    {
        public Gruposcliente()
        {
            Condicionesgruposclientes = new HashSet<Condicionesgruposcliente>();
        }

        public int Idgrupo { get; set; }
        public string? Descripcion { get; set; }
        public byte[]? Version { get; set; }

        public virtual ICollection<Condicionesgruposcliente> Condicionesgruposclientes { get; set; }
    }
}
