using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Retenciones
    {
        [Key]
        public int RetencionId { get; set; }
        public string Descripcion { get; set; }
        public int Valor { get; set; }

        public virtual List<Entidades.Empleados> Empleados { get; set; }

        public Retenciones()
        {
            Empleados = new List<Empleados>();
        }

        public Retenciones(int retencionId, string descripcion, int valor)
        {
            RetencionId = retencionId;
            Descripcion = descripcion;
            Valor = valor;
            Empleados = new List<Empleados>();
        }
    }
}
