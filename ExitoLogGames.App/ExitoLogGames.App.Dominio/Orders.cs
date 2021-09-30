namespace ExitoLogGames.App.Dominio
{
    public class Orders
    {
        public int Id {get; set; }
        public Consola Consola { get; set; }
        public Control Control { get; set; }
        public Videojuego Videojuego { get; set; }
        public int Cantidad { get; set; }
        public double SubTotal{get;set;}
        public string Operacion { get; set; }

    }
}