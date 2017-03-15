using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class TiposEmails
    {
        [Key]
        public int TipoId { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<Entidades.EmpleadosEmails> EmpleadosEmails { get; set; }

        public TiposEmails()
        {
            EmpleadosEmails = new HashSet<Entidades.EmpleadosEmails>();
        }

        public TiposEmails(int tipoId, string descripcion)
        {
            TipoId = tipoId;
            Descripcion = descripcion;
            EmpleadosEmails = new HashSet<Entidades.EmpleadosEmails>();
        }

    }
}
