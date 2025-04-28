using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Articulo1
    {
        public Articulo1()
        {
            Articuloscomentarios = new HashSet<Articuloscomentario>();
            Articuloscomentarioswebs = new HashSet<Articuloscomentariosweb>();
            Articuloscommerces = new HashSet<Articuloscommerce>();
            Articulosdocs = new HashSet<Articulosdoc>();
            Articulosentradashorarios = new HashSet<Articulosentradashorario>();
            Articuloserests = new HashSet<Articuloserest>();
            Articulosfactporfranjas = new HashSet<Articulosfactporfranja>();
            Articulosimagenes = new HashSet<Articulosimagene>();
            Articuloslins = new HashSet<Articuloslin>();
            Habitaciones = new HashSet<Habitacione>();
            Hcuposextras = new HashSet<Hcuposextra>();
            Precioshabitaciondia = new HashSet<Precioshabitaciondium>();
            Preciosregimen = new HashSet<Preciosregiman>();
            Preciossuplementos = new HashSet<Preciossuplemento>();
            Referenciasprovs = new HashSet<Referenciasprov>();
            Situacionesarticulos = new HashSet<Situacionesarticulo>();
            Sustitutos = new HashSet<Sustituto>();
            Turnosarticulosdefectos = new HashSet<Turnosarticulosdefecto>();
            Codregimenrets = new HashSet<Regimenret>();
            CodregimenretsNavigation = new HashSet<Regimenret>();
            Codturnos = new HashSet<Turno>();
            Idtipotarjeta = new HashSet<Tipostarjetum>();
            IdtipotarjetaNavigation = new HashSet<Tipostarjetum>();
        }

        public int Codarticulo { get; set; }
        public string? Descripcion { get; set; }
        public string? Descripadic { get; set; }
        public int? Tipoimpuesto { get; set; }
        public short? Dpto { get; set; }
        public short? Seccion { get; set; }
        public short? Familia { get; set; }
        public short? Subfamilia { get; set; }
        public short? Linea { get; set; }
        public string? Temporada { get; set; }
        public string? Generaretiq { get; set; }
        public byte[]? Foto { get; set; }
        public int? Marca { get; set; }
        public string? Codtalla { get; set; }
        public string? Norma { get; set; }
        public string? Tacon { get; set; }
        public string? Composicion { get; set; }
        public string? Articulovirtual { get; set; }
        public string? Tienetc { get; set; }
        public double? Unid1c { get; set; }
        public double? Unid2c { get; set; }
        public double? Unid3c { get; set; }
        public double? Unid4c { get; set; }
        public double? Unid1v { get; set; }
        public double? Unid2v { get; set; }
        public double? Unid3v { get; set; }
        public double? Unid4v { get; set; }
        public string? Eskit { get; set; }
        public string? Usarnumserie { get; set; }
        public string? Gennumserie { get; set; }
        public int? Tipo { get; set; }
        public DateTime? Fechamodificado { get; set; }
        public string? Refproveedor { get; set; }
        public string? Contrapartidaventa { get; set; }
        public string? Contrapartidacompra { get; set; }
        public string? Unidadmedida { get; set; }
        public double? Udselaboracion { get; set; }
        public double? Medidareferencia { get; set; }
        public string? Porpeso { get; set; }
        public string? Usastocks { get; set; }
        public int? Impuestocompra { get; set; }
        public string? Descatalogado { get; set; }
        public double? Udstraspaso { get; set; }
        public string? Tipoarticulo { get; set; }
        public string? Garantiacompra { get; set; }
        public string? Garantiaventa { get; set; }
        public int? Colorfondo { get; set; }
        public int? Colortexto { get; set; }
        public string? Tiposat { get; set; }
        public DateTime? Factporhora { get; set; }
        public int? Consumadic { get; set; }
        public double? Margen { get; set; }
        public double? Cargo1 { get; set; }
        public double? Cargo2 { get; set; }
        public int? Numconsumiciones { get; set; }
        public int? Codcentral { get; set; }
        public string? Contrapartidacosteventas { get; set; }
        public int? Coddiseny { get; set; }
        public int? Codigoaduana { get; set; }
        public string? Medida2 { get; set; }
        public string? Visibleweb { get; set; }
        public int? Diascaducidad { get; set; }
        public double? Porcretencion { get; set; }
        public string? Contrapartidaconsumo { get; set; }
        public string? Contrapartidaventadmn { get; set; }
        public string? Contrapartidacompradmn { get; set; }
        public string? Contrapartidacosteventasdmn { get; set; }
        public bool? Descargado { get; set; }
        public double? Preciominimo { get; set; }
        public double? Preciomaximo { get; set; }
        public string? Preciolibre { get; set; }
        public bool? HioposImprimircocina { get; set; }
        public bool? HioposEbt { get; set; }
        public int? HioposTakeaway { get; set; }
        public string? Avisoventa { get; set; }
        public byte[]? Fotosha { get; set; }
        public bool? Forzarudsenterasventa { get; set; }
        public int? Duracion { get; set; }
        public int? Idtalonario { get; set; }
        public bool? HioposImprimircocina2 { get; set; }
        public bool? HioposImprimircocina3 { get; set; }
        public bool? HioposIsmodificador { get; set; }
        public bool? Nodtoaplicable { get; set; }
        public string? Contrapartidadevolcompra { get; set; }
        public string? Contrapartidadevolventa { get; set; }
        public string? Contrapartidadevolcosteventa { get; set; }
        public string? Contrapartidadevolcompradmn { get; set; }
        public string? Contrapartidadevolventadmn { get; set; }
        public string? Contrapartidadevolcosteventasdm { get; set; }
        public int? RegimretIva { get; set; }
        public int? RegimretBaseimponible { get; set; }
        public string? Solicitarcomentario { get; set; }
        public string? Dircontab { get; set; }
        public int? Subempresa { get; set; }
        public byte[] Version { get; set; } = null!;
        public string? Contrapartidaventaexonerada { get; set; }
        public string? Contrapartidadevolventaexonerada { get; set; }
        public string? Contrapartidafaltantesinventario { get; set; }
        public string? Contrapartidasobrantesinventario { get; set; }
        public string? Contrapartidaordenesfab { get; set; }
        public string? FijarpvCadadia { get; set; }
        public string? FijarpvAlcambiarprecio { get; set; }
        public int? Formadepeso { get; set; }

        public virtual Articuloscamposlibre? Articuloscamposlibre { get; set; }
        public virtual Articulosentrada? Articulosentrada { get; set; }
        public virtual Articuloshabitacione? Articuloshabitacione { get; set; }
        public virtual Articulosimagen? Articulosimagen { get; set; }
        public virtual Articulosimagenerest? Articulosimagenerest { get; set; }
        public virtual Articulosregimene? Articulosregimene { get; set; }
        public virtual Articulosrest? Articulosrest { get; set; }
        public virtual Cargodtohotel? Cargodtohotel { get; set; }
        public virtual ICollection<Articuloscomentario> Articuloscomentarios { get; set; }
        public virtual ICollection<Articuloscomentariosweb> Articuloscomentarioswebs { get; set; }
        public virtual ICollection<Articuloscommerce> Articuloscommerces { get; set; }
        public virtual ICollection<Articulosdoc> Articulosdocs { get; set; }
        public virtual ICollection<Articulosentradashorario> Articulosentradashorarios { get; set; }
        public virtual ICollection<Articuloserest> Articuloserests { get; set; }
        public virtual ICollection<Articulosfactporfranja> Articulosfactporfranjas { get; set; }
        public virtual ICollection<Articulosimagene> Articulosimagenes { get; set; }
        public virtual ICollection<Articuloslin> Articuloslins { get; set; }
        public virtual ICollection<Habitacione> Habitaciones { get; set; }
        public virtual ICollection<Hcuposextra> Hcuposextras { get; set; }
        public virtual ICollection<Precioshabitaciondium> Precioshabitaciondia { get; set; }
        public virtual ICollection<Preciosregiman> Preciosregimen { get; set; }
        public virtual ICollection<Preciossuplemento> Preciossuplementos { get; set; }
        public virtual ICollection<Referenciasprov> Referenciasprovs { get; set; }
        public virtual ICollection<Situacionesarticulo> Situacionesarticulos { get; set; }
        public virtual ICollection<Sustituto> Sustitutos { get; set; }
        public virtual ICollection<Turnosarticulosdefecto> Turnosarticulosdefectos { get; set; }

        public virtual ICollection<Regimenret> Codregimenrets { get; set; }
        public virtual ICollection<Regimenret> CodregimenretsNavigation { get; set; }
        public virtual ICollection<Turno> Codturnos { get; set; }
        public virtual ICollection<Tipostarjetum> Idtipotarjeta { get; set; }
        public virtual ICollection<Tipostarjetum> IdtipotarjetaNavigation { get; set; }
    }
}
