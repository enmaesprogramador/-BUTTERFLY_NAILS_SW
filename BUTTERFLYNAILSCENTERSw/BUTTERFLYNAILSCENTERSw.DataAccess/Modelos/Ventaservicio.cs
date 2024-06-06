using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace BUTTERFLYNAILSCENTERSw.DataAccess.Modelos;

public partial class Ventaservicio
{
    public int Id { get; set; }

    public int ServicioId { get; set; }

    public int ClienteId { get; set; }

    public int MetodoPagoId { get; set; }

    public int? CitaId { get; set; }

    public DateTime FechaDeRegistro { get; set; }
    [Browsable(false)]
    public virtual Cita? Cita { get; set; }
    [Browsable(false)]
    public virtual Cliente Cliente { get; set; } = null!;
    [Browsable(false)]
    public virtual Metodosdepago MetodoPago { get; set; } = null!;
    [Browsable(false)]
    public virtual Servicio Servicio { get; set; } = null!;
}
