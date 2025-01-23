using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Histocomisionescab
    {
        public Histocomisionescab()
        {
            Comisionesdocs = new HashSet<Comisionesdoc>();
            Histocomisiones = new HashSet<Histocomisione>();
        }

        public int Idcalculo { get; set; }
        public int Codvendedor { get; set; }
        public DateTime Desde { get; set; }
        public DateTime Hasta { get; set; }
        public string? Codnom { get; set; }
        public double? Fijo { get; set; }
        public double? Impostvalor { get; set; }
        public double? Impostperc { get; set; }
        public double? Retencionperc { get; set; }
        public double? Retencionvalor { get; set; }
        public double? Comtotal { get; set; }
        public double? Comisionplusfijo { get; set; }
        public double? Comisionreal { get; set; }
        public int? Modo { get; set; }
        public double? ComisionrealN { get; set; }

        public virtual ICollection<Comisionesdoc> Comisionesdocs { get; set; }
        public virtual ICollection<Histocomisione> Histocomisiones { get; set; }
    }
}
