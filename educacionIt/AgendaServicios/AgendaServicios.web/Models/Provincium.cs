using System;
using System.Collections.Generic;

namespace AgendaServicios.web.Models;

public partial class Provincium
{
    public int ProvinciaId { get; set; }

    public string Descripcion { get; set; } = null!;

    public virtual ICollection<Cliente> Clientes { get; set; } = new List<Cliente>();

    public virtual ICollection<Localidad> Localidads { get; set; } = new List<Localidad>();
}
