using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Vendedore
    {
        public Vendedore()
        {
            Comisioneshechas = new HashSet<Comisioneshecha>();
            Comisionesvendedors = new HashSet<Comisionesvendedor>();
            IdVendedores = new HashSet<IdVendedore>();
            ItRebelAccounts = new HashSet<ItRebelAccount>();
            Nominas = new HashSet<Nomina>();
            Vendedoreshotels = new HashSet<Vendedoreshotel>();
            Vendedoresterminals = new HashSet<Vendedoresterminal>();
            Coddptos = new HashSet<Dptovendedore>();
            Codtipoavisos = new HashSet<Tipoaviso>();
            IdTienda = new HashSet<NetTiendum>();
            Idtipoasuntos = new HashSet<Tipoasunto>();
        }

        public int Codvendedor { get; set; }
        public string? Nomvendedor { get; set; }
        public string? Direccion { get; set; }
        public string? Codpostal { get; set; }
        public string? Poblacion { get; set; }
        public string? Provincia { get; set; }
        public string? Telefono { get; set; }
        public DateTime? Fechanacim { get; set; }
        public string? Lugarnacim { get; set; }
        public DateTime? Fechaentrada { get; set; }
        public string? Observaciones { get; set; }
        public double? Comision { get; set; }
        public string? Fax { get; set; }
        public string? Mobil { get; set; }
        public double? Retencion { get; set; }
        public double? Iva { get; set; }
        public double? Fijo { get; set; }
        public byte[]? Foto { get; set; }
        public string? Passentrada { get; set; }
        public string? Passregistro { get; set; }
        public int? Tipousuario { get; set; }
        public string? Numssocial { get; set; }
        public string? Dni { get; set; }
        public string? Activo { get; set; }
        public DateTime? Fechacaducidadpass { get; set; }
        public string? Bloqueado { get; set; }
        public string? Codalmacen { get; set; }
        public int? Codarticulo { get; set; }
        public string Talla { get; set; } = null!;
        public string Color { get; set; } = null!;
        public string? Descatalogado { get; set; }
        public string? Nombrecorto { get; set; }
        public int? Tipoempleado { get; set; }
        public int? Codigorf { get; set; }
        public double? Costehora { get; set; }
        public double? Costehoraextra { get; set; }
        public string? Usuarioweb { get; set; }
        public string? Passwordweb { get; set; }
        public string? Email { get; set; }
        public string? Centrocoste { get; set; }
        public string? Serienomina { get; set; }
        public string? Codcontable { get; set; }
        public string? Numcuenta { get; set; }
        public string? Codbanco { get; set; }
        public string? Numsucursal { get; set; }
        public string? Digcontrolbanco { get; set; }
        public string? Codpostalbanco { get; set; }
        public string? Codswift { get; set; }
        public string? Nombrebanco { get; set; }
        public string? Direccionbanco { get; set; }
        public string? Poblacionbanco { get; set; }
        public string? Usuariocentralita { get; set; }
        public int? Visibilidad { get; set; }
        public int? Idhotel { get; set; }
        public string? Newpassentrada { get; set; }
        public string? Newpassregistro { get; set; }
        public bool Suscepsustitucion { get; set; }
        public byte[] Version { get; set; } = null!;
        public string? Codigoiban { get; set; }

        public virtual Huellasvendedor? Huellasvendedor { get; set; }
        public virtual ICollection<Comisioneshecha> Comisioneshechas { get; set; }
        public virtual ICollection<Comisionesvendedor> Comisionesvendedors { get; set; }
        public virtual ICollection<IdVendedore> IdVendedores { get; set; }
        public virtual ICollection<ItRebelAccount> ItRebelAccounts { get; set; }
        public virtual ICollection<Nomina> Nominas { get; set; }
        public virtual ICollection<Vendedoreshotel> Vendedoreshotels { get; set; }
        public virtual ICollection<Vendedoresterminal> Vendedoresterminals { get; set; }

        public virtual ICollection<Dptovendedore> Coddptos { get; set; }
        public virtual ICollection<Tipoaviso> Codtipoavisos { get; set; }
        public virtual ICollection<NetTiendum> IdTienda { get; set; }
        public virtual ICollection<Tipoasunto> Idtipoasuntos { get; set; }
    }
}
