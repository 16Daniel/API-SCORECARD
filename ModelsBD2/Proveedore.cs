using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Proveedore
    {
        public Proveedore()
        {
            Albcompracabs = new HashSet<Albcompracab>();
            Cargosdtosproveedors = new HashSet<Cargosdtosproveedor>();
            Facturacionprovcabs = new HashSet<Facturacionprovcab>();
            Fpagoproveedors = new HashSet<Fpagoproveedor>();
            ItRebelAccounts = new HashSet<ItRebelAccount>();
            Rappelsproveedores = new HashSet<Rappelsproveedore>();
            Secuenciacargosprovs = new HashSet<Secuenciacargosprov>();
            TPedidosEntregas = new HashSet<TPedidosEntrega>();
            Tarifascompras = new HashSet<Tarifascompra>();
            Codtiporetencions = new HashSet<Tiposretencion>();
        }

        public int Codproveedor { get; set; }
        public string? Codcontable { get; set; }
        public string? Nomproveedor { get; set; }
        public string? Nomcomercial { get; set; }
        public string? Cif { get; set; }
        public string? Nif20 { get; set; }
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
        public string? Nombrebanco { get; set; }
        public string? Direccionbanco { get; set; }
        public string? Poblacionbanco { get; set; }
        public string? Codswift { get; set; }
        public string? Enviopor { get; set; }
        public string? Enviodirecion { get; set; }
        public string? Enviocodpostal { get; set; }
        public string? Enviopoblacion { get; set; }
        public string? Envioprovincia { get; set; }
        public string? Enviopais { get; set; }
        public double? Cantportespag { get; set; }
        public string? Tipoportes { get; set; }
        public int? Numdiasentrega { get; set; }
        public string? Observaciones { get; set; }
        public string? Codtalla { get; set; }
        public string? Comprarsinimpuestos { get; set; }
        public string? Comprarivaincluido { get; set; }
        public string? Aptocorreos { get; set; }
        public double? Dtocomercial { get; set; }
        public short? Tipo { get; set; }
        public string? Regimfact { get; set; }
        public int? Codmoneda { get; set; }
        public short? Diapago1 { get; set; }
        public short? Diapago2 { get; set; }
        public DateTime? Fechamodificado { get; set; }
        public string? Direccion2 { get; set; }
        public int? Transporte { get; set; }
        public int? Codidioma { get; set; }
        public int? Tipodoc { get; set; }
        public string? Seriealbindirecta { get; set; }
        public string? Seriefacindirecta { get; set; }
        public int? B2bOrigen { get; set; }
        public int? B2bIdmapping { get; set; }
        public int? Codcentral { get; set; }
        public int? Codvisible { get; set; }
        public int? Vencimsegun { get; set; }
        public string? Codpais { get; set; }
        public string? Enviocodpais { get; set; }
        public int? B2bOrigenpedido { get; set; }
        public int? B2bIdmappingpedido { get; set; }
        public int? Codcentralpedido { get; set; }
        public int? Numdiascancelacion { get; set; }
        public double? Pedidominimo { get; set; }
        public int? Facturarconimpuesto { get; set; }
        public string? Codcontablecompra { get; set; }
        public string? Descatalogado { get; set; }
        public string? Codigoiban { get; set; }
        public string? Codcontabledmn { get; set; }
        public int? Pedidosvencimsegun { get; set; }
        public string? Mobil { get; set; }
        public bool? Esprovdelgrupo { get; set; }
        public string? Regimret { get; set; }
        public int? Tiporet { get; set; }
        public int? RetTiporetencioniva { get; set; }
        public double? RetPorcexclusion { get; set; }
        public DateTime? RetFechainiexclusion { get; set; }
        public DateTime? RetFechafinexclusion { get; set; }
        public byte[] Version { get; set; } = null!;
        public bool Ivanodeducible { get; set; }
        public bool Recc { get; set; }
        public string? Bloqueado { get; set; }
        public string? Ordenadeudo { get; set; }

        public virtual Proveedorescamposlibre? Proveedorescamposlibre { get; set; }
        public virtual ICollection<Albcompracab> Albcompracabs { get; set; }
        public virtual ICollection<Cargosdtosproveedor> Cargosdtosproveedors { get; set; }
        public virtual ICollection<Facturacionprovcab> Facturacionprovcabs { get; set; }
        public virtual ICollection<Fpagoproveedor> Fpagoproveedors { get; set; }
        public virtual ICollection<ItRebelAccount> ItRebelAccounts { get; set; }
        public virtual ICollection<Rappelsproveedore> Rappelsproveedores { get; set; }
        public virtual ICollection<Secuenciacargosprov> Secuenciacargosprovs { get; set; }
        public virtual ICollection<TPedidosEntrega> TPedidosEntregas { get; set; }
        public virtual ICollection<Tarifascompra> Tarifascompras { get; set; }

        public virtual ICollection<Tiposretencion> Codtiporetencions { get; set; }
    }
}
