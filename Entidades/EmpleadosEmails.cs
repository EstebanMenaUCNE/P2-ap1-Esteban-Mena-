﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class EmpleadosEmails
    {
        [Key]
        public int Id { get; set; }
        public int EmpleadoId { get; set; }
        public int TipoId { get; set; }
        public string Email { get; set; }

        public virtual Empleados Empleado { get; set; }
        public virtual TiposEmails TiposEmails { get; set; }

        public EmpleadosEmails(string email)
        {
            Email = email;
            Empleado = new Empleados();
            TiposEmails = new TiposEmails();
        }

    }
}
