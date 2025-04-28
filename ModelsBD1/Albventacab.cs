using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Albventacab
    {
        public Albventacab()
        {
            Albventaconsumos = new HashSet<Albventaconsumo>();
            Albventacupones = new HashSet<Albventacupone>();
            Albventacuponesgenerados = new HashSet<Albventacuponesgenerado>();
            Albventadtos = new HashSet<Albventadto>();
            Albventalins = new HashSet<Albventalin>();
            Albventamodifs = new HashSet<Albventamodif>();
            Albventapags = new HashSet<Albventapag>();
            Albventapromociones = new HashSet<Albventapromocione>();
            Albventaregalos = new HashSet<Albventaregalo>();
            Albventatarjeta = new HashSet<Albventatarjeta>();
            Albventatots = new HashSet<Albventatot>();
            Etiquetasenvios = new HashSet<Etiquetasenvio>();
        }

        public string Numserie { get; set; } = null!;
        public int Numalbaran { get; set; }
        public string N { get; set; } = null!;
        public string? Facturado { get; set; }
        public string? Numseriefac { get; set; }
        public int? Numfac { get; set; }
        public string? Nfac { get; set; }
        public string? Tiquet { get; set; }
        public string? Esunprestamo { get; set; }
        public string? Esdevolucion { get; set; }
        public int? Codcliente { get; set; }
        public int? Codvendedor { get; set; }
        public DateTime? Fecha { get; set; }
        public DateTime? Hora { get; set; }
        public string? Enviopor { get; set; }
        public string? Portespag { get; set; }
        public double? Dtocomercial { get; set; }
        public double? Totdtocomercial { get; set; }
        public double? Dtopp { get; set; }
        public double? Totdtopp { get; set; }
        public double? Totalbruto { get; set; }
        public double? Totalimpuestos { get; set; }
        public double? Totalneto { get; set; }
        public double? Totalcoste { get; set; }
        public string? Seleccionado { get; set; }
        public string? Sualbaran { get; set; }
        public int? Codmoneda { get; set; }
        public double? Factormoneda { get; set; }
        public string? Ivaincluido { get; set; }
        public int? Codtarifa { get; set; }
        public string? Vienedefo { get; set; }
        public DateTime? Fechaentrada { get; set; }
        public double? Porc { get; set; }
        public double? Totporc { get; set; }
        public int? Tipodoc { get; set; }
        public int? Tipodocfac { get; set; }
        public int? Sala { get; set; }
        public int? Mesa { get; set; }
        public DateTime? Horafin { get; set; }
        public int? Numcomensales { get; set; }
        public int? Impresiones { get; set; }
        public int? Fo { get; set; }
        public string? Serie { get; set; }
        public int? Z { get; set; }
        public int? Idestado { get; set; }
        public DateTime? Fechamodificado { get; set; }
        public string? Automatico { get; set; }
        public string? Caja { get; set; }
        public double? Totalcosteiva { get; set; }
        public string? Esbarra { get; set; }
        public int? Nbultos { get; set; }
        public int? Transporte { get; set; }
        public int? Codenvio { get; set; }
        public int? Puntosacum { get; set; }
        public int? Idtarjeta { get; set; }
        public double? Totalcargosdtos { get; set; }
        public string? Serieasunto { get; set; }
        public int? Numeroasunto { get; set; }
        public int? Numrollo { get; set; }
        public string? Norecibido { get; set; }
        public int? Puntoscanjeados { get; set; }
        public int? Totalpuntos { get; set; }
        public string? Entransito { get; set; }
        public string? Traspasado { get; set; }
        public int? EnlaceEmpresa { get; set; }
        public int? EnlaceEjercicio { get; set; }
        public int? EnlaceAsiento { get; set; }
        public string? EnlaceUsuario { get; set; }
        public DateTime? Fechatraspaso { get; set; }
        public double? Totalcoste2 { get; set; }
        public double? Totalcosteiva2 { get; set; }
        public DateTime? Fecharecepcion { get; set; }
        public string? Descargar { get; set; }
        public DateTime? Fechacreacion { get; set; }
        public int? Idmotivodto { get; set; }
        public int Numimpresiones { get; set; }
        public DateTime? Horatotal { get; set; }
        public DateTime? Horacocina { get; set; }
        public DateTime? Fechaini { get; set; }
        public DateTime? Fechafin { get; set; }
        public int? Estadodelivery { get; set; }
        public DateTime? Horaelaborado { get; set; }
        public DateTime? Horaasignado { get; set; }
        public DateTime? Horaentregado { get; set; }
        public int? Puntoscanjeopordtocom { get; set; }
        public double? Dtocomantescanjeopuntos { get; set; }

        public virtual Cliente? CodclienteNavigation { get; set; }
        public virtual Albventacamposlibre? Albventacamposlibre { get; set; }
        public virtual Albventafirma? Albventafirma { get; set; }
        public virtual Albventagp? Albventagp { get; set; }
        public virtual Albventarubrica? Albventarubrica { get; set; }
        public virtual Albventatarjetaembarque? Albventatarjetaembarque { get; set; }
        public virtual ICollection<Albventaconsumo> Albventaconsumos { get; set; }
        public virtual ICollection<Albventacupone> Albventacupones { get; set; }
        public virtual ICollection<Albventacuponesgenerado> Albventacuponesgenerados { get; set; }
        public virtual ICollection<Albventadto> Albventadtos { get; set; }
        public virtual ICollection<Albventalin> Albventalins { get; set; }
        public virtual ICollection<Albventamodif> Albventamodifs { get; set; }
        public virtual ICollection<Albventapag> Albventapags { get; set; }
        public virtual ICollection<Albventapromocione> Albventapromociones { get; set; }
        public virtual ICollection<Albventaregalo> Albventaregalos { get; set; }
        public virtual ICollection<Albventatarjeta> Albventatarjeta { get; set; }
        public virtual ICollection<Albventatot> Albventatots { get; set; }
        public virtual ICollection<Etiquetasenvio> Etiquetasenvios { get; set; }
    }
}
