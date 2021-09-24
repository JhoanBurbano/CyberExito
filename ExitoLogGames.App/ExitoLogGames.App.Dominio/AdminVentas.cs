namespace ExitoLogGames.App.Dominio
{
    public class AdminVentas:Employ
    {
        public int Id{get;set;}
        public string Cargo { get; set; }
        public Compras Compras{get;set;}
        public Sales Ventas{get;set;}
    }
}