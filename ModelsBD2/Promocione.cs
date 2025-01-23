using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Promocione
    {
        public Promocione()
        {
            Accionespromocions = new HashSet<Accionespromocion>();
            Promocionesformaspagos = new HashSet<Promocionesformaspago>();
            Promocionesgrupos = new HashSet<Promocionesgrupo>();
            Promocionesgruposalmacens = new HashSet<Promocionesgruposalmacen>();
            Promocionesidiomas = new HashSet<Promocionesidioma>();
            Promocionesincompatibles = new HashSet<Promocionesincompatible>();
            Promocionestarifas = new HashSet<Promocionestarifa>();
            Tarjetaspromocions = new HashSet<Tarjetaspromocion>();
        }

        public int Idpromocion { get; set; }
        public int? Prioridad { get; set; }
        public string? Descripcion { get; set; }
        public string? Textoimprimir { get; set; }
        public DateTime? Fechainicial { get; set; }
        public DateTime? Fechafinal { get; set; }
        public DateTime? Horainicial { get; set; }
        public DateTime? Horafinal { get; set; }
        public string? Diassemana { get; set; }
        public string? Eancupon { get; set; }
        public int? Idtarifav { get; set; }
        public string? Porcada { get; set; }
        public double? Numeroarticulos { get; set; }
        public string? Iguales { get; set; }
        public int? Idgrupo { get; set; }
        public double? Importeminimo { get; set; }
        public byte[]? Version { get; set; }
        public string? Descuentosencascada { get; set; }
        public byte[]? Foto { get; set; }
        public string? Clienteobligatorio { get; set; }
        public string? Actualizarremfronts { get; set; }
        public int? Visibilidad { get; set; }
        public bool? Generaricgfidel { get; set; }
        public int? Tipoaplicacion { get; set; }
        public int? Definebarato { get; set; }
        public int? Tipo { get; set; }
        public string? Cuponserializado { get; set; }
        public string? Cuponini { get; set; }
        public string? Cuponfin { get; set; }
        public string? Cuponserializadoiscv { get; set; }
        public double? Preciomin { get; set; }
        public double? Preciomax { get; set; }
        public string? Filtprecio { get; set; }
        public int? Modoimportecupongenerado { get; set; }
        public double? Valorimportecupongenerado { get; set; }
        public string? Imprimirimportedto { get; set; }
        public int? Condicionaplicacion { get; set; }
        public int? Aplicarnveces { get; set; }
        public int? Idpromocionmain { get; set; }
        public int? Posicion { get; set; }
        public string? Abonable { get; set; }
        public string? Manual { get; set; }
        public string? Cuponserializadoisean13 { get; set; }
        public string? Observaciones1 { get; set; }
        public string? Observaciones2 { get; set; }
        public string? Observaciones3 { get; set; }
        public string? Hipervinculo { get; set; }
        public string? Visibleenvisor { get; set; }
        public string? Textovisibleenvisor { get; set; }
        public string? Descripcionaena { get; set; }
        public int? Grupoimportecupongenerado { get; set; }
        public int? Momentoaplicacion { get; set; }
        public string? Alcomprarminimoaplicarmaximo { get; set; }
        public int? Tipoincompatibilidad { get; set; }
        public string? Textoalaplicar { get; set; }
        public string? Pedircuponserializado { get; set; }
        public string? Nextcuponserializado { get; set; }
        public string? Eancuponalias { get; set; }
        public int? Cadaxpuntoscupongenerado { get; set; }
        public int? Tiporedondeocupongenerado { get; set; }
        public int? Aproximacionredondeocupongenerado { get; set; }
        public string? Mascararedondeocupongenerado { get; set; }
        public int? Idgrupoclientes { get; set; }
        public int? Cumpleanyos { get; set; }

        public virtual ICollection<Accionespromocion> Accionespromocions { get; set; }
        public virtual ICollection<Promocionesformaspago> Promocionesformaspagos { get; set; }
        public virtual ICollection<Promocionesgrupo> Promocionesgrupos { get; set; }
        public virtual ICollection<Promocionesgruposalmacen> Promocionesgruposalmacens { get; set; }
        public virtual ICollection<Promocionesidioma> Promocionesidiomas { get; set; }
        public virtual ICollection<Promocionesincompatible> Promocionesincompatibles { get; set; }
        public virtual ICollection<Promocionestarifa> Promocionestarifas { get; set; }
        public virtual ICollection<Tarjetaspromocion> Tarjetaspromocions { get; set; }
    }
}
