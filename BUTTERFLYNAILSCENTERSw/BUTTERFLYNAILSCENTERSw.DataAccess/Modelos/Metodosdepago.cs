using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace BUTTERFLYNAILSCENTERSw.DataAccess.Modelos;

public partial class Metodosdepago
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public DateTime FechaDeRegistro { get; set; }
    [Browsable(false)]
    public virtual ICollection<Ventaservicio> Ventaservicios { get; set; } = new List<Ventaservicio>();
}
