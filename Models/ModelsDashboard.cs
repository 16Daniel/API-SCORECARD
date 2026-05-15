namespace DashboardApi.Models
{
    public class ModelsDashboard
    {
    }

    public class DataModelReporteVentasSolicitud 
    {
        public DateTime fechaini1 { get; set; }
        public DateTime fechafin1 { get; set; }
        public DateTime fechaini2 { get; set; }
        public DateTime fechafin2 { get; set; }
        public string sucursales { get; set; }
    }

    public class DataModelReporteVentasRespuesta 
    {
        public int idSucursal { get; set; }
        public string nombre { get; set; }
        public double meta1 { get; set; }
        public double meta2 { get; set; }
        public double metasalon { get; set; }
        public List<ventaFecha> ventaFechas { get; set; }

    }

    public class ventaFecha 
    {
        public DateTime fecha { get; set; }
        public double venta { get; set; }
        public int año { get; set; }
        public double ventaSalon { get; set; }
        public double ventaDelivery { get; set; }
    }
}
