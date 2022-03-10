using Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace Contexto
{
    public class ServiceContext: DbContext
    {
        public ServiceContext(DbContextOptions<ServiceContext> options): base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            var usuario = modelBuilder.Entity<Usuario>();

            usuario.ToTable("Usuarios");
            usuario.HasKey(x => x.Id).HasName("PK_USUARIOS_4544DWF");
            usuario.Property(x => x.Identificacion).HasColumnType("numeric(18,0)").IsRequired();
            usuario.Property(x => x.NombreUsuario).HasColumnType("varchar(60)").IsRequired();
            usuario.Property(x => x.Genero).HasColumnType("varchar(16)").IsRequired();
            usuario.Property(x => x.NumeroTelefono).HasColumnType("numeric(18,0)").IsRequired();
            usuario.Property(x => x.Correo).HasColumnType("varchar(100)").IsRequired();
        }

        public DbSet<Usuario> Usuarios { get; set; }
    }
}
