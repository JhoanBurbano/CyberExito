﻿// <auto-generated />
using System;
using ExitoLogGames.App.Persistencia;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ExitoLogGames.App.Persistencia.Migrations
{
    [DbContext(typeof(Connection))]
    [Migration("20211016024824_AddCantidadProductos")]
    partial class AddCantidadProductos
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("ExitoLogGames.App.Dominio.AdminCompras", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Apellido")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cargo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cedula")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sucursal")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Usuario")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("compradores");
                });

            modelBuilder.Entity("ExitoLogGames.App.Dominio.AdminVentas", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Apellido")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cargo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cedula")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ComprasId")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sucursal")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Usuario")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("VentasId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ComprasId");

                    b.HasIndex("VentasId");

                    b.ToTable("administradores");
                });

            modelBuilder.Entity("ExitoLogGames.App.Dominio.Compras", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("CompradorId")
                        .HasColumnType("int");

                    b.Property<int?>("FacturaId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CompradorId");

                    b.HasIndex("FacturaId");

                    b.ToTable("compras");
                });

            modelBuilder.Entity("ExitoLogGames.App.Dominio.Consola", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<int>("CantidadControles")
                        .HasColumnType("int");

                    b.Property<string>("CapacidadAlmacenamiento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Costo")
                        .HasColumnType("float");

                    b.Property<string>("Fabricante")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Precio")
                        .HasColumnType("float");

                    b.Property<string>("Storage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VelocidadProcesamiento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VelocidadRam")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Version")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("consolas");
                });

            modelBuilder.Entity("ExitoLogGames.App.Dominio.Control", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<string>("Compatibilidad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Costo")
                        .HasColumnType("float");

                    b.Property<string>("Fabricante")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Precio")
                        .HasColumnType("float");

                    b.Property<string>("Version")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("controles");
                });

            modelBuilder.Entity("ExitoLogGames.App.Dominio.Factura", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Pagada")
                        .HasColumnType("bit");

                    b.Property<int?>("PedidoConsolasId")
                        .HasColumnType("int");

                    b.Property<int?>("PedidoControlesId")
                        .HasColumnType("int");

                    b.Property<int?>("PedidoVideojuegosId")
                        .HasColumnType("int");

                    b.Property<double>("Total")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("PedidoConsolasId");

                    b.HasIndex("PedidoControlesId");

                    b.HasIndex("PedidoVideojuegosId");

                    b.ToTable("facturas");
                });

            modelBuilder.Entity("ExitoLogGames.App.Dominio.Orders", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<int?>("ConsolaId")
                        .HasColumnType("int");

                    b.Property<int?>("ControlId")
                        .HasColumnType("int");

                    b.Property<string>("Operacion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("SubTotal")
                        .HasColumnType("float");

                    b.Property<int?>("VideojuegoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ConsolaId");

                    b.HasIndex("ControlId");

                    b.HasIndex("VideojuegoId");

                    b.ToTable("orders");
                });

            modelBuilder.Entity("ExitoLogGames.App.Dominio.Sales", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("FacturaId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<int?>("VendedorId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FacturaId");

                    b.HasIndex("VendedorId");

                    b.ToTable("ventas");
                });

            modelBuilder.Entity("ExitoLogGames.App.Dominio.Vendedor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Apellido")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cargo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cedula")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sucursal")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Usuario")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("vendedores");
                });

            modelBuilder.Entity("ExitoLogGames.App.Dominio.Videojuego", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<string>("Compatibilidad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Costo")
                        .HasColumnType("float");

                    b.Property<string>("Fabricante")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Precio")
                        .HasColumnType("float");

                    b.Property<string>("Version")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("videojuegos");
                });

            modelBuilder.Entity("ExitoLogGames.App.Dominio.AdminVentas", b =>
                {
                    b.HasOne("ExitoLogGames.App.Dominio.Compras", "Compras")
                        .WithMany()
                        .HasForeignKey("ComprasId");

                    b.HasOne("ExitoLogGames.App.Dominio.Sales", "Ventas")
                        .WithMany()
                        .HasForeignKey("VentasId");

                    b.Navigation("Compras");

                    b.Navigation("Ventas");
                });

            modelBuilder.Entity("ExitoLogGames.App.Dominio.Compras", b =>
                {
                    b.HasOne("ExitoLogGames.App.Dominio.AdminCompras", "Comprador")
                        .WithMany()
                        .HasForeignKey("CompradorId");

                    b.HasOne("ExitoLogGames.App.Dominio.Factura", "Factura")
                        .WithMany()
                        .HasForeignKey("FacturaId");

                    b.Navigation("Comprador");

                    b.Navigation("Factura");
                });

            modelBuilder.Entity("ExitoLogGames.App.Dominio.Factura", b =>
                {
                    b.HasOne("ExitoLogGames.App.Dominio.Orders", "PedidoConsolas")
                        .WithMany()
                        .HasForeignKey("PedidoConsolasId");

                    b.HasOne("ExitoLogGames.App.Dominio.Orders", "PedidoControles")
                        .WithMany()
                        .HasForeignKey("PedidoControlesId");

                    b.HasOne("ExitoLogGames.App.Dominio.Orders", "PedidoVideojuegos")
                        .WithMany()
                        .HasForeignKey("PedidoVideojuegosId");

                    b.Navigation("PedidoConsolas");

                    b.Navigation("PedidoControles");

                    b.Navigation("PedidoVideojuegos");
                });

            modelBuilder.Entity("ExitoLogGames.App.Dominio.Orders", b =>
                {
                    b.HasOne("ExitoLogGames.App.Dominio.Consola", "Consola")
                        .WithMany()
                        .HasForeignKey("ConsolaId");

                    b.HasOne("ExitoLogGames.App.Dominio.Control", "Control")
                        .WithMany()
                        .HasForeignKey("ControlId");

                    b.HasOne("ExitoLogGames.App.Dominio.Videojuego", "Videojuego")
                        .WithMany()
                        .HasForeignKey("VideojuegoId");

                    b.Navigation("Consola");

                    b.Navigation("Control");

                    b.Navigation("Videojuego");
                });

            modelBuilder.Entity("ExitoLogGames.App.Dominio.Sales", b =>
                {
                    b.HasOne("ExitoLogGames.App.Dominio.Factura", "Factura")
                        .WithMany()
                        .HasForeignKey("FacturaId");

                    b.HasOne("ExitoLogGames.App.Dominio.Vendedor", "Vendedor")
                        .WithMany()
                        .HasForeignKey("VendedorId");

                    b.Navigation("Factura");

                    b.Navigation("Vendedor");
                });
#pragma warning restore 612, 618
        }
    }
}
