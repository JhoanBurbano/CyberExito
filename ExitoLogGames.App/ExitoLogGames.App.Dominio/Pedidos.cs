namespace ExitoLogGames.App.Dominio
{
    public class Pedidos
    {
        public int PedidoId { get; set; }
        public int IdProducto { get; set; }
        public int Cantidad { get; set; }
        public char Operacion { get; set; }

    }
}