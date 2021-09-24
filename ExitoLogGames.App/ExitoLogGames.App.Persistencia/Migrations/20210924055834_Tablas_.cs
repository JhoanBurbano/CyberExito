using Microsoft.EntityFrameworkCore.Migrations;

namespace ExitoLogGames.App.Persistencia.Migrations
{
    public partial class Tablas_ : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "cargo",
                table: "vendedores",
                newName: "Cargo");

            migrationBuilder.RenameColumn(
                name: "cargo",
                table: "compradores",
                newName: "Cargo");

            migrationBuilder.RenameColumn(
                name: "cargo",
                table: "administradores",
                newName: "Cargo");

            migrationBuilder.AddColumn<int>(
                name: "pedidosId",
                table: "ventas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PedidoId",
                table: "compras",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "pedidos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    consolaId = table.Column<int>(type: "int", nullable: true),
                    controlId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    videojuegoId = table.Column<int>(type: "int", nullable: true),
                    Cantidad = table.Column<int>(type: "int", nullable: false),
                    Operacion = table.Column<string>(type: "nvarchar(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pedidos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_pedidos_consolas_consolaId",
                        column: x => x.consolaId,
                        principalTable: "consolas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_pedidos_controles_controlId",
                        column: x => x.controlId,
                        principalTable: "controles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_pedidos_videojuegos_videojuegoId",
                        column: x => x.videojuegoId,
                        principalTable: "videojuegos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ventas_pedidosId",
                table: "ventas",
                column: "pedidosId");

            migrationBuilder.CreateIndex(
                name: "IX_compras_PedidoId",
                table: "compras",
                column: "PedidoId");

            migrationBuilder.CreateIndex(
                name: "IX_pedidos_consolaId",
                table: "pedidos",
                column: "consolaId");

            migrationBuilder.CreateIndex(
                name: "IX_pedidos_controlId",
                table: "pedidos",
                column: "controlId");

            migrationBuilder.CreateIndex(
                name: "IX_pedidos_videojuegoId",
                table: "pedidos",
                column: "videojuegoId");

            migrationBuilder.AddForeignKey(
                name: "FK_compras_pedidos_PedidoId",
                table: "compras",
                column: "PedidoId",
                principalTable: "pedidos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ventas_pedidos_pedidosId",
                table: "ventas",
                column: "pedidosId",
                principalTable: "pedidos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_compras_pedidos_PedidoId",
                table: "compras");

            migrationBuilder.DropForeignKey(
                name: "FK_ventas_pedidos_pedidosId",
                table: "ventas");

            migrationBuilder.DropTable(
                name: "pedidos");

            migrationBuilder.DropIndex(
                name: "IX_ventas_pedidosId",
                table: "ventas");

            migrationBuilder.DropIndex(
                name: "IX_compras_PedidoId",
                table: "compras");

            migrationBuilder.DropColumn(
                name: "pedidosId",
                table: "ventas");

            migrationBuilder.DropColumn(
                name: "PedidoId",
                table: "compras");

            migrationBuilder.RenameColumn(
                name: "Cargo",
                table: "vendedores",
                newName: "cargo");

            migrationBuilder.RenameColumn(
                name: "Cargo",
                table: "compradores",
                newName: "cargo");

            migrationBuilder.RenameColumn(
                name: "Cargo",
                table: "administradores",
                newName: "cargo");
        }
    }
}
