using System;
using System.Collections.Generic;

namespace AgendaServicios.web.Models;

public partial class EstadoTurno
{
    public int EstadoTurnoId { get; set; }

    public string Descripcion { get; set; } = null!;

    public virtual ICollection<Turno> Turnos { get; set; } = new List<Turno>();
}
