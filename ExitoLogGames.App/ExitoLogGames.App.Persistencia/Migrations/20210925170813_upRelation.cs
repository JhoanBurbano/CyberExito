using Microsoft.EntityFrameworkCore.Migrations;

namespace ExitoLogGames.App.Persistencia.Migrations
{
    public partial class upRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_orders_consolas_ControlId",
                table: "orders");

            migrationBuilder.AddForeignKey(
                name: "FK_orders_controles_ControlId",
                table: "orders",
                column: "ControlId",
                principalTable: "controles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_orders_controles_ControlId",
                table: "orders");

            migrationBuilder.AddForeignKey(
                name: "FK_orders_consolas_ControlId",
                table: "orders",
                column: "ControlId",
                principalTable: "consolas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
