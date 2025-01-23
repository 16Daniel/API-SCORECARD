using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Formaspago
    {
        public Formaspago()
        {
            Fpagoclientes = new HashSet<Fpagocliente>();
            Fpagoproveedors = new HashSet<Fpagoproveedor>();
            Vencimfpagos = new HashSet<Vencimfpago>();
        }

        public string Codformapago { get; set; } = null!;
        public string? Descripcion { get; set; }
        public int? Numvencimientos { get; set; }
        public int? Codmoneda { get; set; }
        public string? Dllasoc { get; set; }
        public string? Clienteoblig { get; set; }
        public string? Visiblefront { get; set; }
        public string? Sinsobrepago { get; set; }
        public short? Tipo { get; set; }
        public string? Textoimp { get; set; }
        public string? Usarlawround { get; set; }
        public byte[] Version { get; set; } = null!;
        public int? Idpasarela { get; set; }
        public bool? Abrircajon { get; set; }
        public byte[]? Imagen { get; set; }
        public int? Tiporedondeo { get; set; }
        public string? Marcastarjeta { get; set; }
        public string? Cantotalizar { get; set; }
        public string? Aplicableconotras { get; set; }
        public int? Tiposobrepago { get; set; }
        public string? Codformapagosobrepago { get; set; }
        public double? Dtopp { get; set; }
        public string? Pediridcobro { get; set; }
        public string? Descidcobro { get; set; }
        public int? Aproximacionredondeo { get; set; }
        public int? Orden { get; set; }
        public string? Imprimiragrup { get; set; }

        public virtual ICollection<Fpagocliente> Fpagoclientes { get; set; }
        public virtual ICollection<Fpagoproveedor> Fpagoproveedors { get; set; }
        public virtual ICollection<Vencimfpago> Vencimfpagos { get; set; }
    }
}
