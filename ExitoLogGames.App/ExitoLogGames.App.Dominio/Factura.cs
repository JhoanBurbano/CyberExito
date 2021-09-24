using System;
namespace ExitoLogGames.App.Dominio
{
    public class Factura
    {
        public int Id{set;get;}
        public Pedidos PedidoConsolas{get;set;}
        public Pedidos PedidoControles{get;set;}
        public Pedidos PedidoVideojuegos{get;set;}
        public DateTime Fecha{get;set;}
        public double Total{get;set;}
    }
}