using ExitoLogGames.App.Persistencia;
using ExitoLogGames.App.Dominio;
using System.Linq;
using System.Collections.Generic;
using System;

namespace ExitoLogGames.App.Comandos
{
    public class RepositorioOrders : IRepositorioOrders
    {
        private readonly Connection conexion;
        public RepositorioOrders(Connection conexion){
            this.conexion = conexion;
        }
        IEnumerable<Orders> IRepositorioOrders.GetAllOrders(){
            return conexion.orders;
        }
        Orders IRepositorioOrders.AddOrder(Orders pedido){
            var ord = conexion.orders.Add(pedido);
            return ord.Entity;
            Console.WriteLine("Se creó la pedido");

        }
        Orders IRepositorioOrders.UpdateOrder(Orders pedido){
            var ord = conexion.orders.FirstOrDefault(v => v.Id == v.Id);
            if(ord!=null){
                ord.Consola=pedido.Consola;              
                ord.Control=pedido.Control;              
                ord.Videojuego=pedido.Videojuego;              
                ord.Cantidad=pedido.Cantidad;              
                ord.SubTotal=pedido.SubTotal;              
            }
            return ord;
        }
        void IRepositorioOrders.DeleteOrder(int IdPedido){
            var ord = conexion.orders.FirstOrDefault(v => v.Id == IdPedido);
            if(ord==null)
                return;
            conexion.orders.Remove(ord);
            Console.WriteLine("Se eliminó pedido");
        }
        Orders IRepositorioOrders.GetOrder(int IdPedido){
            return conexion.orders.FirstOrDefault( v => v.Id == IdPedido);
        }
        
    }
}