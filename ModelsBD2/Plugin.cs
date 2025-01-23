using System;
using System.Collections.Generic;

namespace DashboardApi.ModelsBD2
{
    public partial class Plugin
    {
        public int Idplugin { get; set; }
        public int? Idmodulo { get; set; }
        public string? Dllname { get; set; }
        public string? Pluginname { get; set; }
        public string? Descripcion { get; set; }
        public int? Version { get; set; }
        public int? Versionmanager { get; set; }
        public string? Menuitem { get; set; }
        public string? Menucaption { get; set; }
        public int? Imageindex { get; set; }
        public string? Idioma { get; set; }
    }
}
