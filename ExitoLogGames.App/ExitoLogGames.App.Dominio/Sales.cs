using System;
namespace ExitoLogGames.App.Dominio
{
    public class Sales
    {
        public int Id { get; set; }
        public DateTime FechaVenta{get;set;}
        public Vendedor Vendedor{get;set;}
        public Factura Factura{get;set;}


    }
}