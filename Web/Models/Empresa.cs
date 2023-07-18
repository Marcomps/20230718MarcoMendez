namespace Web.Models
{
    public class Empresa
    {
        public int IdEmpresa { get; set; }
        public string Nombre { get; set; }
        public string RazonSocial { get; set; }
        public DateTime? FechaDeRegistro { get; set; }
        public string Bitacora { get; set; }
        public int? IdDepartamento { get; set; }
    }
}
