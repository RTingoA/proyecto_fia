using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Proyecto_Fia.Migrations
{
    public partial class segundo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MensajePagos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(maxLength: 15, nullable: false),
                    Apellido = table.Column<string>(maxLength: 20, nullable: false),
                    Correo = table.Column<string>(nullable: false),
                    Direccion = table.Column<string>(maxLength: 30, nullable: false),
                    DireccionTwo = table.Column<string>(maxLength: 30, nullable: false),
                    Distrito = table.Column<string>(maxLength: 20, nullable: false),
                    Calle = table.Column<string>(maxLength: 30, nullable: false),
                    CodigoPostal = table.Column<string>(maxLength: 10, nullable: false),
                    TipoTarjeta = table.Column<string>(nullable: false),
                    NombreTitular = table.Column<string>(maxLength: 20, nullable: false),
                    NumeroTarjeta = table.Column<string>(maxLength: 20, nullable: false),
                    CodigoExpiracion = table.Column<string>(maxLength: 8, nullable: false),
                    CodigoCvv = table.Column<string>(maxLength: 5, nullable: false),
                    TipoServicio = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MensajePagos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoTarjetas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoTarjetas", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "TipoTarjetas",
                columns: new[] { "Id", "Nombre" },
                values: new object[] { 1, "Visa" });

            migrationBuilder.InsertData(
                table: "TipoTarjetas",
                columns: new[] { "Id", "Nombre" },
                values: new object[] { 2, "Mastercard" });

            migrationBuilder.InsertData(
                table: "TipoTarjetas",
                columns: new[] { "Id", "Nombre" },
                values: new object[] { 3, "Paypal" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MensajePagos");

            migrationBuilder.DropTable(
                name: "TipoTarjetas");
        }
    }
}
