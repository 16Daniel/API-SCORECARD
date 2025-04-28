using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD1
{
    public partial class RemIpfrontslocal
    {
        public int Idfront { get; set; }
        public int Tipo { get; set; }
        public string? Ip { get; set; }
        public int? Puerto { get; set; }
        public string? Usuario { get; set; }
        public string? Passw { get; set; }
    }
}
