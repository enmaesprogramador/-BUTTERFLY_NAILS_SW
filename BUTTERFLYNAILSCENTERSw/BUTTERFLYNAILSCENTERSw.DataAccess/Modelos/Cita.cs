using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace BUTTERFLYNAILSCENTERSw.DataAccess.Modelos;

public partial class Cita
{
    public int Id { get; set; }

    public int ClienteId { get; set; }
    public string? Status { get; set; }
    public int ServicioId { get; set; }
    public DateTime? Fecha { get; set; }    
    public DateTime FechaDeRegistro { get; set; }
    [Browsable(false)]
    public virtual Cliente Cliente { get; set; } = null!;
    [Browsable(false)]
    public virtual Servicio Servicio { get; set; } = null!;
    [Browsable(false)]
    public virtual ICollection<Ventaservicio> Ventaservicios { get; set; } = new List<Ventaservicio>();
}
