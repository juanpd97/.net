using System;
using System.Collections.Generic;

namespace AgendaServicios.web.Models;

public partial class Servicio
{
    public int ServicioId { get; set; }

    public string Descripcion { get; set; } = null!;

    public virtual ICollection<Turno> Turnos { get; set; } = new List<Turno>();
}
