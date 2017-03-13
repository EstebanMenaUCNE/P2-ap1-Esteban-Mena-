using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Retencion
    {
        [Key]
        public int RetencionId { get; set; }
        public string Descripcion { get; set; }
        public int Valor { get; set; }

        public Retencion()
        {

        }

        public Retencion(int retencionId, string descripcion, int valor)
        {
            RetencionId = retencionId;
            Descripcion = descripcion;
            Valor = valor;
        }
    }
}
