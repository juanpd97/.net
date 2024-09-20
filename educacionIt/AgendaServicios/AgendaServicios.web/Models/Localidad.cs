namespace AgendaServicios.web.Models
{
    public class Localidad
    {
        public int LocalidadId { get; set; }
        public string Descripcion {  get; set; }
        public int ProvinciaId { get; set; }
        public Provincia Provincia { get; set; }
    }
}
