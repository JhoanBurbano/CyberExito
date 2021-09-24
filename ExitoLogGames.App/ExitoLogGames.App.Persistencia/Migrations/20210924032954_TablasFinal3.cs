using Microsoft.EntityFrameworkCore.Migrations;

namespace ExitoLogGames.App.Persistencia.Migrations
{
    public partial class TablasFinal3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Costo",
                table: "videojuegos",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "Fabricante",
                table: "videojuegos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Nombre",
                table: "videojuegos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Precio",
                table: "videojuegos",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "Version",
                table: "videojuegos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Costo",
                table: "controles",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "Fabricante",
                table: "controles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Nombre",
                table: "controles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Precio",
                table: "controles",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "Version",
                table: "controles",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Costo",
                table: "videojuegos");

            migrationBuilder.DropColumn(
                name: "Fabricante",
                table: "videojuegos");

            migrationBuilder.DropColumn(
                name: "Nombre",
                table: "videojuegos");

            migrationBuilder.DropColumn(
                name: "Precio",
                table: "videojuegos");

            migrationBuilder.DropColumn(
                name: "Version",
                table: "videojuegos");

            migrationBuilder.DropColumn(
                name: "Costo",
                table: "controles");

            migrationBuilder.DropColumn(
                name: "Fabricante",
                table: "controles");

            migrationBuilder.DropColumn(
                name: "Nombre",
                table: "controles");

            migrationBuilder.DropColumn(
                name: "Precio",
                table: "controles");

            migrationBuilder.DropColumn(
                name: "Version",
                table: "controles");
        }
    }
}
