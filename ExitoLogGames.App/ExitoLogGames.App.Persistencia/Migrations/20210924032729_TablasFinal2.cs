using Microsoft.EntityFrameworkCore.Migrations;

namespace ExitoLogGames.App.Persistencia.Migrations
{
    public partial class TablasFinal2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_compras_AdminCompras_CompradorId",
                table: "compras");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AdminCompras",
                table: "AdminCompras");

            migrationBuilder.RenameTable(
                name: "AdminCompras",
                newName: "compradores");

            migrationBuilder.AddPrimaryKey(
                name: "PK_compradores",
                table: "compradores",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_compras_compradores_CompradorId",
                table: "compras",
                column: "CompradorId",
                principalTable: "compradores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_compras_compradores_CompradorId",
                table: "compras");

            migrationBuilder.DropPrimaryKey(
                name: "PK_compradores",
                table: "compradores");

            migrationBuilder.RenameTable(
                name: "compradores",
                newName: "AdminCompras");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AdminCompras",
                table: "AdminCompras",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_compras_AdminCompras_CompradorId",
                table: "compras",
                column: "CompradorId",
                principalTable: "AdminCompras",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
