using Microsoft.EntityFrameworkCore.Migrations;

namespace Proyecto_Fia.Migrations
{
    public partial class cam2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Sucursales",
                keyColumn: "Id",
                keyValue: 2,
                column: "Nombre",
                value: "Sucursal 1");

            migrationBuilder.UpdateData(
                table: "Sucursales",
                keyColumn: "Id",
                keyValue: 3,
                column: "Nombre",
                value: "Sucursal 2");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Sucursales",
                keyColumn: "Id",
                keyValue: 2,
                column: "Nombre",
                value: "Sucursal Surquillork");

            migrationBuilder.UpdateData(
                table: "Sucursales",
                keyColumn: "Id",
                keyValue: 3,
                column: "Nombre",
                value: "Sucursal San Juan de Luriguashington");
        }
    }
}
