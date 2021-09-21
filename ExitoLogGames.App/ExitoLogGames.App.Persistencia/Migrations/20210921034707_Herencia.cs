using Microsoft.EntityFrameworkCore.Migrations;

namespace ExitoLogGames.App.Persistencia.Migrations
{
    public partial class Herencia : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "empleados",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Usuario",
                table: "empleados",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Password",
                table: "empleados");

            migrationBuilder.DropColumn(
                name: "Usuario",
                table: "empleados");
        }
    }
}
