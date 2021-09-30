using System.Collections.Generic;
using ExitoLogGames.App.Dominio;

namespace ExitoLogGames.App.Persistencia
{
    public interface IRepositorioOrders
    {
        IEnumerable<Orders> GetAllOrders();
        Orders AddOrder(Orders Pedido);
        Orders UpdateOrder(int IdPedido, Orders Pedido);
        void DeleteOrder(int IdPedido);
        Orders GetOrder(int IdPedido);
    }
}