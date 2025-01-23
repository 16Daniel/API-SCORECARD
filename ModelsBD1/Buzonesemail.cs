using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class Buzonesemail
    {
        public int Idbuzon { get; set; }
        public string? Nombreconexion { get; set; }
        public string? Host { get; set; }
        public string? Iduser { get; set; }
        public string? Password { get; set; }
        public int? Tipoautentificacion { get; set; }
        public int? Puerto { get; set; }
        public string? Fromadress { get; set; }
        public string? Fromname { get; set; }
        public string? Cc { get; set; }
    }
}
