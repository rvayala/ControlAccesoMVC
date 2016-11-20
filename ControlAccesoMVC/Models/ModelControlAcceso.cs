namespace ControlAccesoMVC.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ModelControlAcceso : DbContext
    {
        public ModelControlAcceso()
            : base("name=ModelControlAcceso")
        {
        }

        public virtual DbSet<CA_Personas> CA_Personas { get; set; }
        public virtual DbSet<CA_RegistroVisitas> CA_RegistroVisitas { get; set; }
        public virtual DbSet<CAT_AreasVisita> CAT_AreasVisita { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CA_Personas>()
                .Property(e => e.Nombres)
                .IsUnicode(false);

            modelBuilder.Entity<CA_Personas>()
                .Property(e => e.PrimerApellido)
                .IsUnicode(false);

            modelBuilder.Entity<CA_Personas>()
                .Property(e => e.SegundoApellido)
                .IsUnicode(false);

            modelBuilder.Entity<CA_Personas>()
                .HasMany(e => e.CA_RegistroVisitas)
                .WithOptional(e => e.CA_Personas)
                .HasForeignKey(e => e.IdPersona);

            modelBuilder.Entity<CA_RegistroVisitas>()
                .Property(e => e.MotivoVisita)
                .IsUnicode(false);

            modelBuilder.Entity<CAT_AreasVisita>()
                .Property(e => e.Area)
                .IsUnicode(false);

            modelBuilder.Entity<CAT_AreasVisita>()
                .HasMany(e => e.CA_RegistroVisitas)
                .WithOptional(e => e.CAT_AreasVisita)
                .HasForeignKey(e => e.IdAreaVisitada);
        }
    }
}
