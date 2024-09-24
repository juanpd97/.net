using System;
using System.Collections.Generic;

namespace AgendaServicios.web.Models;

public partial class Cliente
{
    public int ClienteId { get; set; }

    public string Apellido { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public DateTime FechaNacimiento { get; set; }

    public string TipoDocumento { get; set; } = null!;

    public int NumeroDocumento { get; set; }

    public string Calle { get; set; } = null!;

    public int Altura { get; set; }

    public string? Barrio { get; set; }

    public string? Partido { get; set; }

    public int ProvinciaId { get; set; }

    public int LocalidadId { get; set; }

    public int CodigoPostal { get; set; }

    public string? CuitCuil { get; set; }

    public string? RazonSocial { get; set; }

    public string? CorreoElectronico { get; set; }

    public string? Celular { get; set; }

    public string? Telefono { get; set; }

    public virtual Localidad Localidad { get; set; } = null!;

    public virtual Provincium Provincia { get; set; } = null!;

    public virtual ICollection<Turno> Turnos { get; set; } = new List<Turno>();
}
