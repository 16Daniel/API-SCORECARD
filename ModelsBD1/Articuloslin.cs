using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Articuloslin
    {
        public Articuloslin()
        {
            CmrcFotosarticuloslins = new HashSet<CmrcFotosarticuloslin>();
            Costesporalmacens = new HashSet<Costesporalmacen>();
            Historicocostes = new HashSet<Historicocoste>();
            Historicokits = new HashSet<Historicokit>();
            Kits = new HashSet<Kit>();
            Moviments = new HashSet<Moviment>();
            Numerosseriereguls = new HashSet<Numerosserieregul>();
            Precioscompras = new HashSet<Precioscompra>();
            Preciosventa = new HashSet<Preciosventum>();
            Regularizacions = new HashSet<Regularizacion>();
            Stocks = new HashSet<Stock>();
            Stocksflags = new HashSet<Stocksflag>();
        }

        public int Codarticulo { get; set; }
        public string Talla { get; set; } = null!;
        public string Color { get; set; } = null!;
        public string? Codbarras { get; set; }
        public double? Costemedio { get; set; }
        public double? Costestock { get; set; }
        public double? Ultimocoste { get; set; }
        public double? Precioultcompra { get; set; }
        public double? Ultdesccomercial { get; set; }
        public int Posiciontalla { get; set; }
        public int Posicioncolor { get; set; }
        public double? Peso { get; set; }
        public double? Unidadescompradas { get; set; }
        public DateTime? Fechaultcompra { get; set; }
        public DateTime? Fechaultventa { get; set; }
        public string? Elaboracion { get; set; }
        public int? Orden { get; set; }
        public string? Codbarras2 { get; set; }
        public int? Codalternativo { get; set; }
        public string? Tallaalternativa { get; set; }
        public string? Coloralternativo { get; set; }
        public int? Codmoneda { get; set; }
        public double? Ultdtocomercial { get; set; }
        public double? Preciocomprareal { get; set; }
        public string? Codbarras3 { get; set; }
        public string? Garantiacompra { get; set; }
        public string? Garantiaventa { get; set; }
        public double? Udsalternativo { get; set; }
        public string? Alternativousaprecio { get; set; }
        public byte[] Version { get; set; } = null!;
        public double? Factormedida2 { get; set; }
        public double? Costemediodmn { get; set; }
        public double? Costestockdmn { get; set; }
        public double? Ultimocostedmn { get; set; }
        public double? Precioultcompradmn { get; set; }
        public double? Preciocomprarealdmn { get; set; }
        public double? Ultdesccomercialdmn { get; set; }
        public double? Ultdtocomercialdmn { get; set; }
        public int? Codmonedadmn { get; set; }
        public double? Unidadescompradasdmn { get; set; }
        public string? Descatalogado { get; set; }
        public double? Importecargo1 { get; set; }
        public double? Importecargo2 { get; set; }
        public double? Importecargo1dmn { get; set; }
        public double? Importecargo2dmn { get; set; }
        public int? Cloudid { get; set; }

        public virtual Articulo1 CodarticuloNavigation { get; set; } = null!;
        public virtual ICollection<CmrcFotosarticuloslin> CmrcFotosarticuloslins { get; set; }
        public virtual ICollection<Costesporalmacen> Costesporalmacens { get; set; }
        public virtual ICollection<Historicocoste> Historicocostes { get; set; }
        public virtual ICollection<Historicokit> Historicokits { get; set; }
        public virtual ICollection<Kit> Kits { get; set; }
        public virtual ICollection<Moviment> Moviments { get; set; }
        public virtual ICollection<Numerosserieregul> Numerosseriereguls { get; set; }
        public virtual ICollection<Precioscompra> Precioscompras { get; set; }
        public virtual ICollection<Preciosventum> Preciosventa { get; set; }
        public virtual ICollection<Regularizacion> Regularizacions { get; set; }
        public virtual ICollection<Stock> Stocks { get; set; }
        public virtual ICollection<Stocksflag> Stocksflags { get; set; }
    }
}
