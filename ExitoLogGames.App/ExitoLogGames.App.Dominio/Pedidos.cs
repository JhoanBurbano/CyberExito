namespace ExitoLogGames.App.Dominio
{
    public class Pedidos
    {
        public int Id { get; set; }
        public Consola consola { get; set; }
        public Control control { get; set; }
        public Videojuego videojuego { get; set; }
        public int Cantidad { get; set; }
        public int SubTotal{get;set;}
        public char Operacion { get; set; }

    }
}