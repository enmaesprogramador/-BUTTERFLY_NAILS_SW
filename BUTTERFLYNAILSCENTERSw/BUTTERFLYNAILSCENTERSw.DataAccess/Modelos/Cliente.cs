using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace BUTTERFLYNAILSCENTERSw.DataAccess.Modelos;

public partial class Cliente
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string? NumeroDeTelefono { get; set; }

    public string? Direccion { get; set; }

    public DateTime FechaDeRegistro { get; set; }
    [Browsable(false)]
    public virtual ICollection<Cita> Cita { get; set; } = new List<Cita>();
    [Browsable(false)]
    public virtual ICollection<Ventaservicio> Ventaservicios { get; set; } = new List<Ventaservicio>();
}
