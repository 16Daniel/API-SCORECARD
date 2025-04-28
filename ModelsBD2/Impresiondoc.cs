using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Impresiondoc
    {
        public Impresiondoc()
        {
            ImpresiondocGruposalmacens = new HashSet<ImpresiondocGruposalmacen>();
            Relcamposlibresubicacions = new HashSet<Relcamposlibresubicacion>();
        }

        public int Grupo { get; set; }
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public int? Idioma { get; set; }
        public string? Ivainc { get; set; }
        public int? Ncopias { get; set; }
        public string? Cerrado { get; set; }
        public byte[]? Imagen { get; set; }
        public int? Tipo { get; set; }
        public DateTime? Fecha { get; set; }
        public string? Sqlfija { get; set; }
        public string? Sql { get; set; }
        public int? Codtitulo { get; set; }
        public byte[]? Diseny { get; set; }
        public string? Texto1 { get; set; }
        public string? Texto2 { get; set; }
        public double? Numerico1 { get; set; }
        public double? Numerico2 { get; set; }
        public string? Booleandos { get; set; }
        public byte[] Version { get; set; } = null!;
        public short Ver { get; set; }
        public byte[]? Disenyver2 { get; set; }

        public virtual ICollection<ImpresiondocGruposalmacen> ImpresiondocGruposalmacens { get; set; }
        public virtual ICollection<Relcamposlibresubicacion> Relcamposlibresubicacions { get; set; }
    }
}
