using Microsoft.EntityFrameworkCore.Migrations;

namespace ExitoLogGames.App.Persistencia.Migrations
{
    public partial class Start : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "empleados",
                newName: "EmployId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EmployId",
                table: "empleados",
                newName: "Id");
        }
    }
}
