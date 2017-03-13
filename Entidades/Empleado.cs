using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Empleado
    {
        [Key]
        public int EmpleadoId { get; set; }
        public string Nombres { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public decimal Sueldo { get; set; }

        public virtual ICollection<EmpleadoRetencion> EmpleadosRetenciones { get; set; }
        public virtual ICollection<EmpleadoEmail> EmpleadosEmails { get; set; }

        public Empleado()
        {
            EmpleadosRetenciones = new HashSet<EmpleadoRetencion>();
            EmpleadosEmails = new HashSet<EmpleadoEmail>();
        }

        public void AgregarDetalleRetencion()
        {
            EmpleadosRetenciones.Add(new EmpleadoRetencion());
        }

        public void AgregarDetalleTipoEmail()
        {
            EmpleadosEmails.Add(new EmpleadoEmail());
        }
    }
}
