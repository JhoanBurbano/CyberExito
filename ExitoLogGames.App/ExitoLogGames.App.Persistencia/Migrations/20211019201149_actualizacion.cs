using Microsoft.EntityFrameworkCore.Migrations;

namespace ExitoLogGames.App.Persistencia.Migrations
{
    public partial class actualizacion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_facturas_orders_PedidoConsolasId",
                table: "facturas");

            migrationBuilder.DropForeignKey(
                name: "FK_facturas_orders_PedidoControlesId",
                table: "facturas");

            migrationBuilder.DropForeignKey(
                name: "FK_facturas_orders_PedidoVideojuegosId",
                table: "facturas");

            migrationBuilder.DropTable(
                name: "orders");

            migrationBuilder.AddColumn<int>(
                name: "CantidadConsolas",
                table: "facturas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CantidadControles",
                table: "facturas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CantidadVideojuegos",
                table: "facturas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_facturas_consolas_PedidoConsolasId",
                table: "facturas",
                column: "PedidoConsolasId",
                principalTable: "consolas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_facturas_controles_PedidoControlesId",
                table: "facturas",
                column: "PedidoControlesId",
                principalTable: "controles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_facturas_videojuegos_PedidoVideojuegosId",
                table: "facturas",
                column: "PedidoVideojuegosId",
                principalTable: "videojuegos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_facturas_consolas_PedidoConsolasId",
                table: "facturas");

            migrationBuilder.DropForeignKey(
                name: "FK_facturas_controles_PedidoControlesId",
                table: "facturas");

            migrationBuilder.DropForeignKey(
                name: "FK_facturas_videojuegos_PedidoVideojuegosId",
                table: "facturas");

            migrationBuilder.DropColumn(
                name: "CantidadConsolas",
                table: "facturas");

            migrationBuilder.DropColumn(
                name: "CantidadControles",
                table: "facturas");

            migrationBuilder.DropColumn(
                name: "CantidadVideojuegos",
                table: "facturas");

            migrationBuilder.CreateTable(
                name: "orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cantidad = table.Column<int>(type: "int", nullable: false),
                    ConsolaId = table.Column<int>(type: "int", nullable: true),
                    ControlId = table.Column<int>(type: "int", nullable: true),
                    Operacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubTotal = table.Column<double>(type: "float", nullable: false),
                    VideojuegoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_orders_consolas_ConsolaId",
                        column: x => x.ConsolaId,
                        principalTable: "consolas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_orders_controles_ControlId",
                        column: x => x.ControlId,
                        principalTable: "controles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_orders_videojuegos_VideojuegoId",
                        column: x => x.VideojuegoId,
                        principalTable: "videojuegos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_orders_ConsolaId",
                table: "orders",
                column: "ConsolaId");

            migrationBuilder.CreateIndex(
                name: "IX_orders_ControlId",
                table: "orders",
                column: "ControlId");

            migrationBuilder.CreateIndex(
                name: "IX_orders_VideojuegoId",
                table: "orders",
                column: "VideojuegoId");

            migrationBuilder.AddForeignKey(
                name: "FK_facturas_orders_PedidoConsolasId",
                table: "facturas",
                column: "PedidoConsolasId",
                principalTable: "orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_facturas_orders_PedidoControlesId",
                table: "facturas",
                column: "PedidoControlesId",
                principalTable: "orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_facturas_orders_PedidoVideojuegosId",
                table: "facturas",
                column: "PedidoVideojuegosId",
                principalTable: "orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
