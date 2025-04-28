using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Histocomisione
    {
        public int Idcalculo { get; set; }
        public int Codlinea { get; set; }
        public int Codvendedor { get; set; }
        public DateTime? Hasta { get; set; }
        public DateTime? Desde { get; set; }
        public string? Descripcioncomision { get; set; }
        public string? Modoaplicacion { get; set; }
        public string? Modocalculo { get; set; }
        public int? Depto { get; set; }
        public int? Seccion { get; set; }
        public int? Familia { get; set; }
        public int? Subfamilia { get; set; }
        public int? Marca { get; set; }
        public int? Linea { get; set; }
        public string? Referencia { get; set; }
        public int? Tipo { get; set; }
        public int? Operacion { get; set; }
        public string? Areanegocio { get; set; }
        public int? Filtroventas { get; set; }
        public int? Modo { get; set; }
        public int? Impuestos { get; set; }
        public double? Ventabrutas { get; set; }
        public double? Ventasnetas { get; set; }
        public double? Comision { get; set; }
        public double? Comisionreal { get; set; }
        public double? Rangoini { get; set; }
        public double? Rangofin { get; set; }
        public double? Porcentajecelda { get; set; }
        public double? Dtototal { get; set; }
        public int? Grupoarticulo { get; set; }
        public int? Tipocliente { get; set; }
        public int? Idcomision { get; set; }
        public string? Temporada { get; set; }

        public virtual Histocomisionescab Histocomisionescab { get; set; } = null!;
    }
}
