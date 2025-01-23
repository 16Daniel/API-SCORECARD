using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Moneda
    {
        public Moneda()
        {
            Cotizaciones = new HashSet<Cotizacione>();
            Monedaslins = new HashSet<Monedaslin>();
            IdTienda = new HashSet<NetTiendum>();
        }

        public int Codmoneda { get; set; }
        public string? Descripcion { get; set; }
        public string? Iniciales { get; set; }
        public double? Cantidadprin { get; set; }
        public double? Cantidadsec { get; set; }
        public short? Numdecimales { get; set; }
        public string? Numerador { get; set; }
        public string? Principal { get; set; }
        public byte[]? Imagen { get; set; }
        public double? Cotdef { get; set; }
        public string? Aplicarcotdef { get; set; }
        public double? Mora { get; set; }
        public double? Comisioncambio { get; set; }
        public string? Inicialesdelante { get; set; }
        public byte[]? Version { get; set; }
        public byte[]? ImagenPng { get; set; }
        public string? Codigoiso { get; set; }
        public string? Codigoisonum { get; set; }
        public string? Cambiootramoneda { get; set; }

        public virtual ICollection<Cotizacione> Cotizaciones { get; set; }
        public virtual ICollection<Monedaslin> Monedaslins { get; set; }

        public virtual ICollection<NetTiendum> IdTienda { get; set; }
    }
}
