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

        public DbSet<Retenciones> Retenciones { get; set; }
        public DbSet<TiposEmails> TiposEmails { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Empleados>()
                .HasMany(Empleado => Empleado.Retenciones)
                .WithMany(Retencion => Retencion.Empleados)
                .Map(EmpleadosRetenciones =>
                {
                    EmpleadosRetenciones.MapLeftKey("EmpleadoId");
                    EmpleadosRetenciones.MapRightKey("RetencionId");
                    EmpleadosRetenciones.ToTable("EmpleadosRetenciones");
                }
                );
        }
    }
}
