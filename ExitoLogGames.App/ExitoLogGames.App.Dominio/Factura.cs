using System;
namespace ExitoLogGames.App.Dominio
{
    public class Factura
    {
        public int Id{set;get;}
        public Employ empleado{get;set;}
        public Consola PedidoConsolas{get;set;}
        public int CantidadConsolas{get;set;}
        public Control PedidoControles{get;set;}
        public int CantidadControles{get;set;}
        public Videojuego PedidoVideojuegos{get;set;}
        public int CantidadVideojuegos{get;set;}
        public DateTime Fecha{get;set;}
        public double Total{get;set;}
        public bool Pagada{get; set;}
    }
}