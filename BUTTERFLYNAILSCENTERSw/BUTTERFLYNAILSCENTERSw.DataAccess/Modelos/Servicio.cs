using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace BUTTERFLYNAILSCENTERSw.DataAccess.Modelos;

public partial class Servicio
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Descripcion { get; set; }

    public double Precio { get; set; }

    public DateTime FechaRegistro { get; set; }
    [Browsable(false)]
    public virtual ICollection<Cita> Cita { get; set; } = new List<Cita>();
    [Browsable(false)]
    public virtual ICollection<Ventaservicio> Ventaservicios { get; set; } = new List<Ventaservicio>();
}
