using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Empleados
    {
        [Key]
        public int EmpleadoId { get; set; }
        public string Nombres { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public double Sueldo { get; set; }

        public virtual List<Entidades.Retenciones> Retenciones { get; set; }
        public virtual ICollection<EmpleadosEmails> EmpleadosEmails { get; set; }

        public Empleados()
        {
            Retenciones = new List<Retenciones>();
            EmpleadosEmails = new HashSet<EmpleadosEmails>();
        }

        public Empleados(int empleadoId, string nombres, DateTime fechaNacimiento, double sueldo)
        {
            EmpleadoId = empleadoId;
            Nombres = nombres;
            FechaNacimiento = fechaNacimiento;
            Sueldo = sueldo;
            Retenciones = new List<Retenciones>();
            EmpleadosEmails = new HashSet<EmpleadosEmails>();
        }
        
        public void AgregarDetalleTipoEmail(EmpleadosEmails empleadoEmail)
        {
            EmpleadosEmails.Add(empleadoEmail);
        }
    }
}
