namespace ExitoLogGames.App.Dominio
{
    public class Compras

    {
        public int Id { get; set; }
        public AdminCompras Comprador{get;set;}
        public Pedidos Pedido{get;set;}
    }
}