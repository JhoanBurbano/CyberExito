using System;
namespace ExitoLogGames.App.Dominio
{
    public class Factura
    {
        public int Id{set;get;}
        public Orders PedidoConsolas{get;set;}
        public Orders PedidoControles{get;set;}
        public Orders PedidoVideojuegos{get;set;}
        public DateTime Fecha{get;set;}
        public double Total{get;set;}
        public bool Pagada{get; set;}
    }
}