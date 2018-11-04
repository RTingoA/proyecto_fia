using Microsoft.EntityFrameworkCore.Migrations;

namespace Proyecto_Fia.Migrations
{
    public partial class comensamos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "correo",
                table: "Mensajes",
                newName: "Correo");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Correo",
                table: "Mensajes",
                newName: "correo");
        }
    }
}
