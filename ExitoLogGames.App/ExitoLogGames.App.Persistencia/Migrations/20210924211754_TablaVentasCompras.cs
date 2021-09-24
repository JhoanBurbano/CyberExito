using Microsoft.EntityFrameworkCore.Migrations;

namespace ExitoLogGames.App.Persistencia.Migrations
{
    public partial class TablaVentasCompras : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_compras_pedidos_PedidoId",
                table: "compras");

            migrationBuilder.DropForeignKey(
                name: "FK_ventas_pedidos_pedidosId",
                table: "ventas");

            migrationBuilder.RenameColumn(
                name: "pedidosId",
                table: "ventas",
                newName: "FacturaId");

            migrationBuilder.RenameIndex(
                name: "IX_ventas_pedidosId",
                table: "ventas",
                newName: "IX_ventas_FacturaId");

            migrationBuilder.RenameColumn(
                name: "PedidoId",
                table: "compras",
                newName: "FacturaId");

            migrationBuilder.RenameIndex(
                name: "IX_compras_PedidoId",
                table: "compras",
                newName: "IX_compras_FacturaId");

            migrationBuilder.AddForeignKey(
                name: "FK_compras_facturas_FacturaId",
                table: "compras",
                column: "FacturaId",
                principalTable: "facturas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ventas_facturas_FacturaId",
                table: "ventas",
                column: "FacturaId",
                principalTable: "facturas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_compras_facturas_FacturaId",
                table: "compras");

            migrationBuilder.DropForeignKey(
                name: "FK_ventas_facturas_FacturaId",
                table: "ventas");

            migrationBuilder.RenameColumn(
                name: "FacturaId",
                table: "ventas",
                newName: "pedidosId");

            migrationBuilder.RenameIndex(
                name: "IX_ventas_FacturaId",
                table: "ventas",
                newName: "IX_ventas_pedidosId");

            migrationBuilder.RenameColumn(
                name: "FacturaId",
                table: "compras",
                newName: "PedidoId");

            migrationBuilder.RenameIndex(
                name: "IX_compras_FacturaId",
                table: "compras",
                newName: "IX_compras_PedidoId");

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
    }
}
