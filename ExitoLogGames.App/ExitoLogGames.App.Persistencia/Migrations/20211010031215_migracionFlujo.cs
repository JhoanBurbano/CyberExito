using Microsoft.EntityFrameworkCore.Migrations;

namespace ExitoLogGames.App.Persistencia.Migrations
{
    public partial class migracionFlujo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Tipo",
                table: "videojuegos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Pagada",
                table: "facturas",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Tipo",
                table: "controles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Tipo",
                table: "consolas",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Tipo",
                table: "videojuegos");

            migrationBuilder.DropColumn(
                name: "Pagada",
                table: "facturas");

            migrationBuilder.DropColumn(
                name: "Tipo",
                table: "controles");

            migrationBuilder.DropColumn(
                name: "Tipo",
                table: "consolas");
        }
    }
}
