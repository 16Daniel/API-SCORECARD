using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Sql
    {
        public int Id { get; set; }
        public string? Descripcion { get; set; }
        public string? Textosql { get; set; }
        public int? Tipobd { get; set; }
        public string? Parsear { get; set; }
    }
}
