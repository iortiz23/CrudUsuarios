using Microsoft.EntityFrameworkCore.Migrations;

namespace CrudUsuarios.Migrations
{
    public partial class Migration_001 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Identificacion = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    NombreUsuario = table.Column<string>(type: "varchar(60)", nullable: false),
                    Genero = table.Column<string>(type: "varchar(16)", nullable: false),
                    NumeroTelefono = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    Correo = table.Column<string>(type: "varchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_USUARIOS_4544DWF", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
