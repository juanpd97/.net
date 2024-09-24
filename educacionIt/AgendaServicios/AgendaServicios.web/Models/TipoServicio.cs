using System;
using System.Collections.Generic;

namespace AgendaServicios.web.Models;

public partial class TipoServicio
{
    public int TipoServicioId { get; set; }

    public string Descripcion { get; set; } = null!;
}
