using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Series
    {
        public Series()
        {
            Habitaciones = new HashSet<Habitacione>();
            Seriesdocs = new HashSet<Seriesdoc>();
        }

        public string Serie { get; set; } = null!;
        public string? Descripcion { get; set; }
        public string? Centrocoste { get; set; }
        public int? Numpedcb { get; set; }
        public int? Numpedcn { get; set; }
        public int? Numalbcb { get; set; }
        public int? Numalbcn { get; set; }
        public int? Numfaccb { get; set; }
        public int? Numfaccn { get; set; }
        public int? Numpedvb { get; set; }
        public int? Numpedvn { get; set; }
        public int? Numalbvb { get; set; }
        public int? Numalbvn { get; set; }
        public int? Numfacvb { get; set; }
        public int? Numfacvn { get; set; }
        public int? Numdevcb { get; set; }
        public int? Numdevcn { get; set; }
        public int? Numdevvb { get; set; }
        public int? Numdevvn { get; set; }
        public int? Numdepob { get; set; }
        public int? Numdepon { get; set; }
        public int? Numpresb { get; set; }
        public int? Numpresn { get; set; }
        public int? Numfabb { get; set; }
        public string? Contabilidadb { get; set; }
        public string? Contabilidadn { get; set; }
        public string? Recargo { get; set; }
        public int? Numcobrostesb { get; set; }
        public int? Numcobrostesn { get; set; }
        public int? Numpagostesb { get; set; }
        public int? Numpagostesn { get; set; }
        public int? Numtrasp { get; set; }
        public int? Nummerma { get; set; }
        public int? Id { get; set; }
        public int? Idparent { get; set; }
        public int? Posicion { get; set; }
        public double? Coste { get; set; }
        public string? Sufijocontable { get; set; }
        public string? Ventas { get; set; }
        public string? Clientesvarios { get; set; }
        public DateTime? Fechaaccesocontab { get; set; }
        public string? Compras { get; set; }
        public string? Costeventas { get; set; }
        public string? Dtoppventas { get; set; }
        public string? Dtoppcompras { get; set; }
        public string? Cuentapagos { get; set; }
        public string? Tipodocumento { get; set; }
        public string? Certificada { get; set; }
        public string? Transporte { get; set; }
        public string? Tipodocumentotransporte { get; set; }
        public string? Tipodocecuador { get; set; }
        public string? Nombrecertificadodigital { get; set; }
        public int? Numcomretm { get; set; }
        public int? Numcomrete { get; set; }
        public string? Autofacv { get; set; }
        public int? Modofiscal { get; set; }

        public virtual Seriescamposlibre? Seriescamposlibre { get; set; }
        public virtual ICollection<Habitacione> Habitaciones { get; set; }
        public virtual ICollection<Seriesdoc> Seriesdocs { get; set; }
    }
}
