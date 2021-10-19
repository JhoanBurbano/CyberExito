using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ExitoLogGames.App.Persistencia.Migrations
{
    public partial class NewAge : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "consolas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CapacidadAlmacenamiento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VelocidadRam = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VelocidadProcesamiento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CantidadControles = table.Column<int>(type: "int", nullable: false),
                    Storage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Version = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fabricante = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Precio = table.Column<double>(type: "float", nullable: false),
                    Costo = table.Column<double>(type: "float", nullable: false),
                    Cantidad = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_consolas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "controles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Compatibilidad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Version = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fabricante = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Precio = table.Column<double>(type: "float", nullable: false),
                    Costo = table.Column<double>(type: "float", nullable: false),
                    Cantidad = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_controles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "empleados",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Apellido = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cedula = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sucursal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cargo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Usuario = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_empleados", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "videojuegos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Compatibilidad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Version = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fabricante = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Precio = table.Column<double>(type: "float", nullable: false),
                    Costo = table.Column<double>(type: "float", nullable: false),
                    Cantidad = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_videojuegos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ConsolaId = table.Column<int>(type: "int", nullable: true),
                    ControlId = table.Column<int>(type: "int", nullable: true),
                    VideojuegoId = table.Column<int>(type: "int", nullable: true),
                    Cantidad = table.Column<int>(type: "int", nullable: false),
                    SubTotal = table.Column<double>(type: "float", nullable: false),
                    Operacion = table.Column<string>(type: "nvarchar(max)", nullable: true)
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

            migrationBuilder.CreateTable(
                name: "facturas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    empleadoId = table.Column<int>(type: "int", nullable: true),
                    PedidoConsolasId = table.Column<int>(type: "int", nullable: true),
                    PedidoControlesId = table.Column<int>(type: "int", nullable: true),
                    PedidoVideojuegosId = table.Column<int>(type: "int", nullable: true),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Total = table.Column<double>(type: "float", nullable: false),
                    Pagada = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_facturas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_facturas_empleados_empleadoId",
                        column: x => x.empleadoId,
                        principalTable: "empleados",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_facturas_orders_PedidoConsolasId",
                        column: x => x.PedidoConsolasId,
                        principalTable: "orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_facturas_orders_PedidoControlesId",
                        column: x => x.PedidoControlesId,
                        principalTable: "orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_facturas_orders_PedidoVideojuegosId",
                        column: x => x.PedidoVideojuegosId,
                        principalTable: "orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_facturas_empleadoId",
                table: "facturas",
                column: "empleadoId");

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "facturas");

            migrationBuilder.DropTable(
                name: "empleados");

            migrationBuilder.DropTable(
                name: "orders");

            migrationBuilder.DropTable(
                name: "consolas");

            migrationBuilder.DropTable(
                name: "controles");

            migrationBuilder.DropTable(
                name: "videojuegos");
        }
    }
}
