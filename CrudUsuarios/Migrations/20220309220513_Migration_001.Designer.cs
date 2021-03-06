// <auto-generated />
using Contexto;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CrudUsuarios.Migrations
{
    [DbContext(typeof(ServiceContext))]
    [Migration("20220309220513_Migration_001")]
    partial class Migration_001
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Entities.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Correo")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Genero")
                        .IsRequired()
                        .HasColumnType("varchar(16)");

                    b.Property<decimal>("Identificacion")
                        .HasColumnType("numeric(18,0)");

                    b.Property<string>("NombreUsuario")
                        .IsRequired()
                        .HasColumnType("varchar(60)");

                    b.Property<decimal>("NumeroTelefono")
                        .HasColumnType("numeric(18,0)");

                    b.HasKey("Id")
                        .HasName("PK_USUARIOS_4544DWF");

                    b.ToTable("Usuarios");
                });
#pragma warning restore 612, 618
        }
    }
}
