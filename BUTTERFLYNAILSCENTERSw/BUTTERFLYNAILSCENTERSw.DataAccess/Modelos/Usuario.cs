using System;
using System.Collections.Generic;

namespace BUTTERFLYNAILSCENTERSw.DataAccess.Modelos;

public partial class Usuario
{
    public int Id { get; set; }

    public string? Username { get; set; }

    public string? Password { get; set; }
    public string? Rol { get; set; }

    public DateTime FechaRegistro { get; set; }
}
