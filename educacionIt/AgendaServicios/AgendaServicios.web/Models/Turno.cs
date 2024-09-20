namespace AgendaServicios.web.Models
{
    public class Turno
    {
        public int TurnoId { get; set; }
        public DateTime FechaTurno { get; set; }
        public DateTime HoraTunrno { get; set; }
        public int EstadoTurnoId { get; set; }
        public int CLienteId { get; set; }
        public int ServicioId { get; set; }
        public string Observacion { get; set; }
        public Cliente Cliente { get; set; }
        public EstadoTurno EstadoTurno { get; set; }
        public TipoServicio TipoServicio { get; set; }
    }
}
