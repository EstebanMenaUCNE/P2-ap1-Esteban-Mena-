using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class TipoEmail
    {
        [Key]
        public int TipoId { get; set; }
        public string Descripcion { get; set; }

        public TipoEmail()
        {

        }

        public TipoEmail(int tipoId, string descripcion)
        {
            TipoId = tipoId;
            Descripcion = descripcion;
        }

    }
}
