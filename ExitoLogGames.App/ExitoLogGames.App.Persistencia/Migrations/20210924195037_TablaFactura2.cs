using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ExitoLogGames.App.Persistencia.Migrations
{
    public partial class TablaFactura2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "facturas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PedidoConsolasId = table.Column<int>(type: "int", nullable: true),
                    PedidoControlesId = table.Column<int>(type: "int", nullable: true),
                    PedidoVideojuegosId = table.Column<int>(type: "int", nullable: true),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Total = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_facturas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_facturas_pedidos_PedidoConsolasId",
                        column: x => x.PedidoConsolasId,
                        principalTable: "pedidos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_facturas_pedidos_PedidoControlesId",
                        column: x => x.PedidoControlesId,
                        principalTable: "pedidos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_facturas_pedidos_PedidoVideojuegosId",
                        column: x => x.PedidoVideojuegosId,
                        principalTable: "pedidos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_facturas_PedidoConsolasId",
                table: "facturas",
                column: "PedidoConsolasId");

            migrationBuilder.CreateIndex(
                name: "IX_facturas_PedidoControlesId",
                table: "facturas",
                column: "PedidoControlesId");

            migrationBuilder.CreateIndex(
                name: "IX_facturas_PedidoVideojuegosId",
                table: "facturas",
                column: "PedidoVideojuegosId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "facturas");
        }
    }
}
