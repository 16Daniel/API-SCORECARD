using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class NetTiendum
    {
        public NetTiendum()
        {
            NetFamiliasTienda = new HashSet<NetFamiliasTiendum>();
            NetTerminals = new HashSet<NetTerminal>();
            CodTipoPagos = new HashSet<Tipospago>();
            CodVendedors = new HashSet<Vendedore>();
            IdMoneda = new HashSet<Moneda>();
            IdMotivoDescuentos = new HashSet<Motivosdto>();
            IdMotivoDevolucions = new HashSet<Motivosdevolucion>();
            IdTarifas = new HashSet<Tarifasventum>();
            TipoIvas = new HashSet<Impuesto>();
        }

        public int IdTienda { get; set; }
        public string? Codigo { get; set; }
        public string? Nombre { get; set; }
        public string? NombreComercial { get; set; }
        public byte[]? Imagen { get; set; }
        public string? Direccion { get; set; }
        public string? Direccion2 { get; set; }
        public string? CodigoPostal { get; set; }
        public string? Poblacion { get; set; }
        public string? Provincia { get; set; }
        public string? Telefono { get; set; }
        public string? Email { get; set; }
        public string? Cif { get; set; }
        public int? IdTipoTerminal { get; set; }
        public int? IdGrupoTienda { get; set; }
        public int? IdIdioma { get; set; }
        public string? CampoImpuestoVenta { get; set; }

        public virtual NetGrupoTiendum? IdGrupoTiendaNavigation { get; set; }
        public virtual NetTipoTerminal? IdTipoTerminalNavigation { get; set; }
        public virtual ICollection<NetFamiliasTiendum> NetFamiliasTienda { get; set; }
        public virtual ICollection<NetTerminal> NetTerminals { get; set; }

        public virtual ICollection<Tipospago> CodTipoPagos { get; set; }
        public virtual ICollection<Vendedore> CodVendedors { get; set; }
        public virtual ICollection<Moneda> IdMoneda { get; set; }
        public virtual ICollection<Motivosdto> IdMotivoDescuentos { get; set; }
        public virtual ICollection<Motivosdevolucion> IdMotivoDevolucions { get; set; }
        public virtual ICollection<Tarifasventum> IdTarifas { get; set; }
        public virtual ICollection<Impuesto> TipoIvas { get; set; }
    }
}
