using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Cliente
    {
        public Cliente()
        {
            Albventacabs = new HashSet<Albventacab>();
            AnulAlbventacabs = new HashSet<AnulAlbventacab>();
            Articulosdiariosclientes = new HashSet<Articulosdiarioscliente>();
            Articulosperiodicosclientes = new HashSet<Articulosperiodicoscliente>();
            Asuntosautomaticos = new HashSet<Asuntosautomatico>();
            Cargodtohotelprecios = new HashSet<Cargodtohotelprecio>();
            Cargosdtosclientes = new HashSet<Cargosdtoscliente>();
            Clientesenvios = new HashSet<Clientesenvio>();
            Clientestarifascompras = new HashSet<Clientestarifascompra>();
            Fpagoclientes = new HashSet<Fpagocliente>();
            Hcuposclientes = new HashSet<Hcuposcliente>();
            Hcuposdia = new HashSet<Hcuposdium>();
            Paqueteshotelclientes = new HashSet<Paqueteshotelcliente>();
            Precioshoteldia = new HashSet<Precioshoteldium>();
            Tarifasclientedmns = new HashSet<Tarifasclientedmn>();
            Tarifasclientes = new HashSet<Tarifascliente>();
            Tarifashotelclientes = new HashSet<Tarifashotelcliente>();
            Tarjetasclientes = new HashSet<Tarjetascliente>();
        }

        public int Codcliente { get; set; }
        public string? Codcontable { get; set; }
        public string? Nombrecliente { get; set; }
        public string? Nombrecomercial { get; set; }
        public string? Cif { get; set; }
        public string? Alias { get; set; }
        public string? Direccion1 { get; set; }
        public string? Codpostal { get; set; }
        public string? Poblacion { get; set; }
        public string? Provincia { get; set; }
        public string? Pais { get; set; }
        public string? Personacontacto { get; set; }
        public string? Telefono1 { get; set; }
        public string? Telefono2 { get; set; }
        public string? Fax { get; set; }
        public string? Faxpedidos { get; set; }
        public string? Telex { get; set; }
        public string? EMail { get; set; }
        public string? Codclisuyo { get; set; }
        public string? Numcuenta { get; set; }
        public string? Codbanco { get; set; }
        public string? Numsucursal { get; set; }
        public string? Digcontrolbanco { get; set; }
        public string? Codpostalbanco { get; set; }
        public string? Codswift { get; set; }
        public string? Nombrebanco { get; set; }
        public string? Direccionbanco { get; set; }
        public string? Poblacionbanco { get; set; }
        public string? Enviopor { get; set; }
        public string? Enviodirecion { get; set; }
        public string? Enviocodpostal { get; set; }
        public string? Enviopoblacion { get; set; }
        public string? Envioprovincia { get; set; }
        public string? Enviopais { get; set; }
        public double? Cantportespag { get; set; }
        public string? Tipoportes { get; set; }
        public int? Numdiasentrega { get; set; }
        public double? Riesgoconcedido { get; set; }
        public short? Tipo { get; set; }
        public string? Recargo { get; set; }
        public string? Zona { get; set; }
        public int? Codvendedor { get; set; }
        public short? Diapago1 { get; set; }
        public short? Diapago2 { get; set; }
        public string? Observaciones { get; set; }
        public string? Facturarsinimpuestos { get; set; }
        public string? Apdocorreos { get; set; }
        public double? Dtocomercial { get; set; }
        public DateTime? Fechamodificado { get; set; }
        public string? Regimfact { get; set; }
        public int? Codmoneda { get; set; }
        public string? Direccion2 { get; set; }
        public string? Compradoredi { get; set; }
        public string? Receptoredi { get; set; }
        public string? Clienteedi { get; set; }
        public string? Pagadoredi { get; set; }
        public string? Usuario { get; set; }
        public string? Pass { get; set; }
        public int? Tipodoc { get; set; }
        public string? Numtarjeta { get; set; }
        public DateTime? Fechanacimiento { get; set; }
        public string? Sexo { get; set; }
        public string? Nif20 { get; set; }
        public string? Descatalogado { get; set; }
        public int? Transporte { get; set; }
        public int? Mesvacaciones { get; set; }
        public int? Grupoimpresion { get; set; }
        public int? Numcopiasfactura { get; set; }
        public int? Tipocliente { get; set; }
        public string? Condentregaedi { get; set; }
        public string? Condentrega { get; set; }
        public int? Codidioma { get; set; }
        public string? Serie { get; set; }
        public string? Almacen { get; set; }
        public string? LocalRemota { get; set; }
        public int? Empresa { get; set; }
        public string? Codentrega { get; set; }
        public string? Procedencia { get; set; }
        public int? Codigoprocedencia { get; set; }
        public int? Idsucursal { get; set; }
        public int? Codvisible { get; set; }
        public string? Codpais { get; set; }
        public int? B2bIdmapping { get; set; }
        public int? Facturarconimpuesto { get; set; }
        public byte[]? Fotocliente { get; set; }
        public int? Cargosfijosa { get; set; }
        public int? Tipotarjeta { get; set; }
        public string? Tarcaducidad { get; set; }
        public string? Cvc { get; set; }
        public string? Codcontabledmn { get; set; }
        public int? DisenyoCamposlibres { get; set; }
        public string? Mobil { get; set; }
        public bool? Nocalcularcargo1artic { get; set; }
        public bool? Nocalcularcargo2artic { get; set; }
        public bool? Esclientedelgrupo { get; set; }
        public string? Passwordcommerce { get; set; }
        public int? Tiporeserva { get; set; }
        public string? Regimret { get; set; }
        public int? Tiporet { get; set; }
        public int? RetTiporetencioniva { get; set; }
        public double? RetPorcexclusion { get; set; }
        public DateTime? RetFechainiexclusion { get; set; }
        public DateTime? RetFechafinexclusion { get; set; }
        public bool? Camposlibrestotalizar { get; set; }
        public int? Codcliasoc { get; set; }
        public byte[] Version { get; set; } = null!;
        public int? Cargosextrasa { get; set; }
        public double? Comision { get; set; }
        public int? Proveedorcomision { get; set; }
        public bool? Comisionesfacturables { get; set; }
        public bool? Localizadorobligatorio { get; set; }
        public bool Recc { get; set; }
        public string? Bloqueado { get; set; }
        public string? Ordenadeudo { get; set; }
        public int? Subnorma { get; set; }
        public int? Secuenciaadeudo { get; set; }
        public string? Codigoiban { get; set; }
        public DateTime? Fechafirmaordenadeudo { get; set; }

        public virtual Clientescamposlibre? Clientescamposlibre { get; set; }
        public virtual Huellascliente? Huellascliente { get; set; }
        public virtual ICollection<Albventacab> Albventacabs { get; set; }
        public virtual ICollection<AnulAlbventacab> AnulAlbventacabs { get; set; }
        public virtual ICollection<Articulosdiarioscliente> Articulosdiariosclientes { get; set; }
        public virtual ICollection<Articulosperiodicoscliente> Articulosperiodicosclientes { get; set; }
        public virtual ICollection<Asuntosautomatico> Asuntosautomaticos { get; set; }
        public virtual ICollection<Cargodtohotelprecio> Cargodtohotelprecios { get; set; }
        public virtual ICollection<Cargosdtoscliente> Cargosdtosclientes { get; set; }
        public virtual ICollection<Clientesenvio> Clientesenvios { get; set; }
        public virtual ICollection<Clientestarifascompra> Clientestarifascompras { get; set; }
        public virtual ICollection<Fpagocliente> Fpagoclientes { get; set; }
        public virtual ICollection<Hcuposcliente> Hcuposclientes { get; set; }
        public virtual ICollection<Hcuposdium> Hcuposdia { get; set; }
        public virtual ICollection<Paqueteshotelcliente> Paqueteshotelclientes { get; set; }
        public virtual ICollection<Precioshoteldium> Precioshoteldia { get; set; }
        public virtual ICollection<Tarifasclientedmn> Tarifasclientedmns { get; set; }
        public virtual ICollection<Tarifascliente> Tarifasclientes { get; set; }
        public virtual ICollection<Tarifashotelcliente> Tarifashotelclientes { get; set; }
        public virtual ICollection<Tarjetascliente> Tarjetasclientes { get; set; }
    }
}
