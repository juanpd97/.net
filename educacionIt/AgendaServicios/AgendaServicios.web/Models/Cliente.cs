namespace AgendaServicios.web.Models
{
    public class Cliente
    {
        public int ClienteId { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string TipoDocumento { get;set; }
        public int NumeroDocumento { get; set; }
        public string Calle {  get; set; }
        public int Altura { get; set; }
        public string Barrio { get; set; }
        public string Partido { get; set; }
        public int  ProvinciaId { get; set; }
        public int LocalidadId { get; set; }
        public int CodigoPostal { get; set; }
        public string CuitCuil {  get; set; }
        public string RazonSocial { get; set; }
        public string CorreoElectronico { get; set; }
        public string Celular {  get; set; }
        public string Telefono { get; set; }
    }
}
