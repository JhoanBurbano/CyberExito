using System;
namespace ExitoLogGames.App.Dominio
{
    public class Sales
    {
        public int Id {get;set;}
        public DateTime Fecha{get;set;}
        public Vendedor Vendedor{get;set;}
        public Factura Factura{get;set;}


    }
}