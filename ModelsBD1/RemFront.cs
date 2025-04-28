using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class RemFront
    {
        public RemFront()
        {
            Configactualizacions = new HashSet<Configactualizacion>();
            RemAcciones = new HashSet<RemAccione>();
            RemCajasfronts = new HashSet<RemCajasfront>();
            RemCajasfrontsseriessubempresas = new HashSet<RemCajasfrontsseriessubempresa>();
            RemConfigdisenysimpresorarests = new HashSet<RemConfigdisenysimpresorarest>();
            RemConfigscreens = new HashSet<RemConfigscreen>();
            RemControlreplicacions = new HashSet<RemControlreplicacion>();
            RemCubiertos = new HashSet<RemCubierto>();
            RemDispositivos = new HashSet<RemDispositivo>();
            RemDispositivosrests = new HashSet<RemDispositivosrest>();
            RemFrontspropiedades = new HashSet<RemFrontspropiedade>();
            RemFrontssubempresas = new HashSet<RemFrontssubempresa>();
            RemGrupossecsimpresorarests = new HashSet<RemGrupossecsimpresorarest>();
            RemHotelesFronts = new HashSet<RemHotelesFront>();
            RemImpresoras = new HashSet<RemImpresora>();
            RemImpresorasrests = new HashSet<RemImpresorasrest>();
            RemInfoentidadesfronts = new HashSet<RemInfoentidadesfront>();
            RemInfoversionesfronts = new HashSet<RemInfoversionesfront>();
            RemListasfronts = new HashSet<RemListasfront>();
            RemModelosimpresorarests = new HashSet<RemModelosimpresorarest>();
            RemSalas = new HashSet<RemSala>();
            RemSecsimpresorarests = new HashSet<RemSecsimpresorarest>();
            RemSecsimpresoras = new HashSet<RemSecsimpresora>();
            RemSqlsfronts = new HashSet<RemSqlsfront>();
            RemTerminales = new HashSet<RemTerminale>();
            RemTerminalesrests = new HashSet<RemTerminalesrest>();
            TPedidosEntregas = new HashSet<TPedidosEntrega>();
        }

        public int Idfront { get; set; }
        public string? Titulo { get; set; }
        public short? Tipo { get; set; }
        public string? Usuario { get; set; }
        public string? Passw { get; set; }
        public string? Accesosarticulo { get; set; }
        public int? Codcliente { get; set; }
        public int? Codproveedor { get; set; }
        public bool? Escliente { get; set; }
        public bool? Filtrarvendedores { get; set; }
        public bool? Filtrarclientes { get; set; }
        public bool? Filtrarproveedores { get; set; }
        public string? Codcontablevarios { get; set; }
        public string? Raizcontablecod { get; set; }
        public bool? Filtrarfpago { get; set; }
        public bool? Clienteunico { get; set; }
        public int? Codclienteunico { get; set; }
        public string? Opcionescentral { get; set; }
        public string? Inicializacion { get; set; }
        public string? Cif { get; set; }
        public string? Nombre { get; set; }
        public string? Nombrecomercial { get; set; }
        public string? Direccion { get; set; }
        public string? Codpostal { get; set; }
        public string? Poblacion { get; set; }
        public string? Provincia { get; set; }
        public string? Email { get; set; }
        public string? Desctasa1 { get; set; }
        public string? Desctasa2 { get; set; }
        public string? Telefono { get; set; }
        public string? Fax { get; set; }
        public byte[]? Logo { get; set; }
        public string? Descidfiscal { get; set; }
        public string? CobrosRemotos { get; set; }
        public string? ValesRemotos { get; set; }
        public string? Serverftp { get; set; }
        public string? Directorioftp { get; set; }
        public int? Puertoftp { get; set; }
        public string? Usuarioftp { get; set; }
        public string? Passwordftp { get; set; }
        public string? Terminalftp { get; set; }
        public string? Directorio { get; set; }
        public int? Estadoftp { get; set; }
        public string? Errordescargaftp { get; set; }
        public string? Tserver { get; set; }
        public int? Codidioma { get; set; }
        public int? Frecuenciaimport { get; set; }
        public string? Entidadesimport { get; set; }
        public int? Frecuenciaexport { get; set; }
        public string? Entidadesexport { get; set; }
        public string? Plantillaventa { get; set; }
        public string? Opcionesasuntos { get; set; }
        public int? Idhotel { get; set; }
        public bool? Filtrarpromociones { get; set; }
        public string? Impuestoartic { get; set; }
        public string? Cuetagastosredondeo { get; set; }
        public string? Cuetaingresosredondeo { get; set; }
        public int? Tipoimpuestodef { get; set; }
        public int? Frecuenciaconexion { get; set; }
        public bool? Usafoodstamp { get; set; }
        public string? Fpagofoodstamp { get; set; }
        public int? Tipoartfoodstamp { get; set; }
        public string? Auditoria { get; set; }
        public string? Datosproveedor { get; set; }
        public string? Nombrecomercial2 { get; set; }
        public string? Direccion2 { get; set; }
        public string? Raizcontableprov { get; set; }
        public string? Raizcontabledeudor { get; set; }
        public string? Raizcontableacreedor { get; set; }
        public bool? Nocalcpreciosimport { get; set; }
        public int? Versionexe { get; set; }
        public byte? Doblecoste { get; set; }
        public string? Almacendoblecoste { get; set; }
        public int? Tarifavdoblecoste { get; set; }
        public bool? Camta { get; set; }
        public int? Gruporecurso { get; set; }
        public bool? Filtrarconceptospago { get; set; }
        public bool? Noenviarclientesrango { get; set; }
        public bool? Filtrargruposrecursos { get; set; }
        public bool? Filtrargruposempleados { get; set; }
        public bool? Calcularriesgocliente { get; set; }
        public bool? Usafremote { get; set; }
        public string? Serverfremote { get; set; }
        public int? Puertofremote { get; set; }
        public bool Abonoscentralizados { get; set; }
        public int? Codmoneda { get; set; }
        public bool? Ignorarudsventa { get; set; }
        public int? Codconceptodescuadre { get; set; }
        public int? Codconceptoretirada { get; set; }
        public bool? Modcli { get; set; }
        public bool? Filtrarmotivosdto { get; set; }
        public bool? Canclact { get; set; }
        public string? Imparticcompra { get; set; }
        public string? Raizanticiposdeudor { get; set; }
        public string? Raizanticiposcliente { get; set; }
        public string? Titplantillaret { get; set; }
        public bool? Usadescargasauto { get; set; }
        public DateTime? Horadescargasauto { get; set; }
        public DateTime? Fechaultimadescarga { get; set; }
        public DateTime? Fechapeticiondescarga { get; set; }
        public string? Flagsdescargasauto { get; set; }
        public string? Raizrecargasgratis { get; set; }
        public int? Codviscli { get; set; }
        public bool? Fvisibpromo { get; set; }
        public bool? Fvisibvend { get; set; }
        public bool? Fvisibtarifv { get; set; }
        public bool? Filtrarfavoritos { get; set; }
        public bool? Coloresestserv { get; set; }
        public bool? Ignorarudscompra { get; set; }
        public bool? Cliobligvales { get; set; }
        public bool? Fotofptotales { get; set; }
        public bool? Checkletracif { get; set; }
        public bool? Vnsss { get; set; }
        public int? Genventascli { get; set; }
        public bool? Actnumfisc { get; set; }
        public bool? Mostnsz { get; set; }
        public string? Almacen { get; set; }
        public int? Numcajas { get; set; }
        public string? Cajafuerte { get; set; }
        public string? Codalmacencentral { get; set; }
        public bool? Filtrocreatarjetas { get; set; }
        public bool? Configemail { get; set; }
        public string? Licencia { get; set; }
        public bool? Modclitarjetas { get; set; }
        public bool Ventasclientecentral { get; set; }
        public bool? Pockmngcentr { get; set; }
        public DateTime? Ultactstocks { get; set; }
        public bool? Filtrousotarjetas { get; set; }
        public bool? Actimmediato { get; set; }
        public bool? Descatalogado { get; set; }
        public bool? Usacostesxalm { get; set; }
        public string? Codalmcostes { get; set; }
        public bool? Filtraralmacenes { get; set; }
        public int? Codconceptoentrada { get; set; }
        public string? ContratoAena { get; set; }
        public string? AeropuertoAena { get; set; }
        public string? LocalAena { get; set; }
        public string? Espaciofiscal { get; set; }
        public string? Numpolicia { get; set; }
        public string? Crc { get; set; }
        public string? Numcrc { get; set; }
        public string? Pais { get; set; }
        public int? Codvisible { get; set; }
        public bool? Filtrarconceptosajuste { get; set; }
        public bool? Filtrardisenyosemail { get; set; }
        public bool Filtrarmotivosdescuadre { get; set; }
        public bool? Filtrarrutas { get; set; }
        public bool? Enviarclientesrutas { get; set; }
        public bool? Bloquearbdotroequipo { get; set; }
        public string? Proteccionhardware { get; set; }
        public int? Diasnomodifdatos { get; set; }
        public int? Subtipo { get; set; }
        public bool? Ownpack { get; set; }
        public bool? Filtrarmotivosabono { get; set; }
        public bool? Filtrarmotivostraspaso { get; set; }
        public bool? Filtrarturnos { get; set; }
        public bool Enviarpedidoscompraproveedores { get; set; }

        public virtual RemConfigemailfront? RemConfigemailfront { get; set; }
        public virtual RemInitconfiguracione? RemInitconfiguracione { get; set; }
        public virtual ShowHorariofront? ShowHorariofront { get; set; }
        public virtual ICollection<Configactualizacion> Configactualizacions { get; set; }
        public virtual ICollection<RemAccione> RemAcciones { get; set; }
        public virtual ICollection<RemCajasfront> RemCajasfronts { get; set; }
        public virtual ICollection<RemCajasfrontsseriessubempresa> RemCajasfrontsseriessubempresas { get; set; }
        public virtual ICollection<RemConfigdisenysimpresorarest> RemConfigdisenysimpresorarests { get; set; }
        public virtual ICollection<RemConfigscreen> RemConfigscreens { get; set; }
        public virtual ICollection<RemControlreplicacion> RemControlreplicacions { get; set; }
        public virtual ICollection<RemCubierto> RemCubiertos { get; set; }
        public virtual ICollection<RemDispositivo> RemDispositivos { get; set; }
        public virtual ICollection<RemDispositivosrest> RemDispositivosrests { get; set; }
        public virtual ICollection<RemFrontspropiedade> RemFrontspropiedades { get; set; }
        public virtual ICollection<RemFrontssubempresa> RemFrontssubempresas { get; set; }
        public virtual ICollection<RemGrupossecsimpresorarest> RemGrupossecsimpresorarests { get; set; }
        public virtual ICollection<RemHotelesFront> RemHotelesFronts { get; set; }
        public virtual ICollection<RemImpresora> RemImpresoras { get; set; }
        public virtual ICollection<RemImpresorasrest> RemImpresorasrests { get; set; }
        public virtual ICollection<RemInfoentidadesfront> RemInfoentidadesfronts { get; set; }
        public virtual ICollection<RemInfoversionesfront> RemInfoversionesfronts { get; set; }
        public virtual ICollection<RemListasfront> RemListasfronts { get; set; }
        public virtual ICollection<RemModelosimpresorarest> RemModelosimpresorarests { get; set; }
        public virtual ICollection<RemSala> RemSalas { get; set; }
        public virtual ICollection<RemSecsimpresorarest> RemSecsimpresorarests { get; set; }
        public virtual ICollection<RemSecsimpresora> RemSecsimpresoras { get; set; }
        public virtual ICollection<RemSqlsfront> RemSqlsfronts { get; set; }
        public virtual ICollection<RemTerminale> RemTerminales { get; set; }
        public virtual ICollection<RemTerminalesrest> RemTerminalesrests { get; set; }
        public virtual ICollection<TPedidosEntrega> TPedidosEntregas { get; set; }
    }
}
