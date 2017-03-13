using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace DAL
{
    public class ParcialDb : DbContext
    {
        public ParcialDb() : base("ConStr")
        {
                
        }

        public DbSet<Retencion> Retenciones { get; set; }
        public DbSet<TipoEmail> TiposEmails { get; set; }
    }
}
