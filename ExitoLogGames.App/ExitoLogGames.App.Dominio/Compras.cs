using System;

namespace ExitoLogGames.App.Dominio
{
    public class Compras

    {
        public int Id { get; set; }
        public DateTime Fecha{get;set;}
        public AdminCompras Comprador{get;set;}
        public Factura Factura{get;set;}
    }
}