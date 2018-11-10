using Microsoft.EntityFrameworkCore.Migrations;

namespace Proyecto_Fia.Migrations
{
    public partial class segund : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Calle",
                table: "MensajePagos");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Calle",
                table: "MensajePagos",
                maxLength: 30,
                nullable: false,
                defaultValue: "");
        }
    }
}
