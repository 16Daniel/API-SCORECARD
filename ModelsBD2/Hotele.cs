using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Hotele
    {
        public Hotele()
        {
            Festivoshotels = new HashSet<Festivoshotel>();
            Hcuposclientes = new HashSet<Hcuposcliente>();
            Hcuposextras = new HashSet<Hcuposextra>();
            Hcuposrestricciones = new HashSet<Hcuposrestriccione>();
            Hcuposservicios = new HashSet<Hcuposservicio>();
            Hoteleshabitaciones = new HashSet<Hoteleshabitacione>();
            Hoteleshabitacioneswebs = new HashSet<Hoteleshabitacionesweb>();
            Hotelesregimenes = new HashSet<Hotelesregimene>();
            Hotelestarifas = new HashSet<Hotelestarifa>();
            Hotelestarifascargos = new HashSet<Hotelestarifascargo>();
            Hotelestarifasextras = new HashSet<Hotelestarifasextra>();
            RemListashoteles = new HashSet<RemListashotele>();
        }

        public int Idhotel { get; set; }
        public string? Descripcion { get; set; }
        public int? Camas { get; set; }
        public string? Codpais { get; set; }
        public string? Nif { get; set; }
        public string? Direccion { get; set; }
        public string? Codpostal { get; set; }
        public string? Poblacion { get; set; }
        public string? Provincia { get; set; }
        public string? Telefono1 { get; set; }
        public string? Telefono2 { get; set; }
        public string? Fax { get; set; }
        public string? Email { get; set; }
        public string? Seriereservas { get; set; }
        public string? Seriefacturas { get; set; }
        public string? Serietiquets { get; set; }
        public string? Seriealbaranes { get; set; }
        public string? Serieinvitaciones { get; set; }
        public int? Intervalorefresco { get; set; }
        public int? Colorfuente { get; set; }
        public string? Textointernet { get; set; }
        public string? Textocancelacion { get; set; }
        public int? Estadoconcupo { get; set; }
        public int? Estadosincupo { get; set; }
        public string? Textowebcupo { get; set; }
        public string? Textowebsincupo { get; set; }
        public int? Tarifaweb { get; set; }
        public string? Campospersona { get; set; }
        public int? Calcproduccion { get; set; }
        public string? Textowebcondicionespago { get; set; }
        public int? Regimenweb { get; set; }
        public int? Tipohabcheckin { get; set; }
        public int? Estadodefconcupo { get; set; }
        public int? Estadodefsincupo { get; set; }
        public string? Cuentapuente { get; set; }
        public string? Cuentaventas { get; set; }
        public int? Iniciosemana { get; set; }
        public bool? Recalcularnumsemana { get; set; }
        public string? Serieabonos { get; set; }
        public string? Textosinlicencia { get; set; }
        public string? Almacenweb { get; set; }
        public int Estadoanul { get; set; }
        public string? Usuario { get; set; }
        public string? Passwd { get; set; }
        public short Idpasarela { get; set; }
        public short Tipopagocta { get; set; }
        public double Porcacta { get; set; }
        public bool Enproduccion { get; set; }
        public string? Codcomercio { get; set; }
        public string? Titularcomercio { get; set; }
        public string? Nombrecomercio { get; set; }
        public string? Terminal { get; set; }
        public string? Caja { get; set; }
        public string? Clave { get; set; }
        public string? Claveencriptacion { get; set; }
        public string? Codfpagopasarela { get; set; }
        public string? Seriepasarela { get; set; }
        public string? Cajahotel { get; set; }
        public int? Tarifawebextras { get; set; }
        public int? Mailcheckindiasantelacion { get; set; }
        public bool? Mailcheckinenviar { get; set; }
        public bool? Mailcheckoutenviar { get; set; }
        public int? Mailcheckindocumento { get; set; }
        public int? Mailcheckoutdocumento { get; set; }
        public string? Dinguserver { get; set; }
        public int? Dinguserverport { get; set; }
        public int? Mailconfirmacionreservadocumento { get; set; }
        public string? Fhxusuario { get; set; }
        public string? Fhxpassword { get; set; }
        public string? Seriegastos { get; set; }
        public int? Selecciontarifapaquete { get; set; }
        public bool? Enviarcopiahotel { get; set; }
        public string? Serieabonostiquets { get; set; }
        public int? Mailconfirmacionreservadisenyo { get; set; }
        public int? Mailcheckoutdisenyo { get; set; }
        public int? Mailcheckindisenyo { get; set; }

        public virtual Dingustazzy? Dingustazzy { get; set; }
        public virtual ICollection<Festivoshotel> Festivoshotels { get; set; }
        public virtual ICollection<Hcuposcliente> Hcuposclientes { get; set; }
        public virtual ICollection<Hcuposextra> Hcuposextras { get; set; }
        public virtual ICollection<Hcuposrestriccione> Hcuposrestricciones { get; set; }
        public virtual ICollection<Hcuposservicio> Hcuposservicios { get; set; }
        public virtual ICollection<Hoteleshabitacione> Hoteleshabitaciones { get; set; }
        public virtual ICollection<Hoteleshabitacionesweb> Hoteleshabitacioneswebs { get; set; }
        public virtual ICollection<Hotelesregimene> Hotelesregimenes { get; set; }
        public virtual ICollection<Hotelestarifa> Hotelestarifas { get; set; }
        public virtual ICollection<Hotelestarifascargo> Hotelestarifascargos { get; set; }
        public virtual ICollection<Hotelestarifasextra> Hotelestarifasextras { get; set; }
        public virtual ICollection<RemListashotele> RemListashoteles { get; set; }
    }
}
