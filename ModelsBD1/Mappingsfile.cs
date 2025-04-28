using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Mappingsfile
    {
        public Mappingsfile()
        {
            Mappingsfields = new HashSet<Mappingsfield>();
            Mappingsfilesmainfields = new HashSet<Mappingsfilesmainfield>();
            Mappingsfilesparametros = new HashSet<Mappingsfilesparametro>();
            Mappingsfilessortedfields = new HashSet<Mappingsfilessortedfield>();
        }

        public int Idmap { get; set; }
        public int Idfile { get; set; }
        public int? Posicion { get; set; }
        public int? Tipofichero { get; set; }
        public int? Primeralineaimportar { get; set; }
        public string? Hayseparadordecimal { get; set; }
        public string? Separadordecimal { get; set; }
        public string? Formatofecha { get; set; }
        public string? Filtrolineas { get; set; }
        public string? Delimitador { get; set; }
        public string? Delimitadorfinal { get; set; }
        public string? Sqlexport { get; set; }
        public int? Idfileparent { get; set; }
        public int? Tipojoin { get; set; }
        public string? Hayseparadormiles { get; set; }
        public string? Separadormiles { get; set; }
        public string? Formatohora { get; set; }
        public string? Descripcion { get; set; }
        public string? Paramtag { get; set; }
        public string? Tienecampos { get; set; }
        public string? Separadorlineas { get; set; }

        public virtual Mappingscab IdmapNavigation { get; set; } = null!;
        public virtual ICollection<Mappingsfield> Mappingsfields { get; set; }
        public virtual ICollection<Mappingsfilesmainfield> Mappingsfilesmainfields { get; set; }
        public virtual ICollection<Mappingsfilesparametro> Mappingsfilesparametros { get; set; }
        public virtual ICollection<Mappingsfilessortedfield> Mappingsfilessortedfields { get; set; }
    }
}
