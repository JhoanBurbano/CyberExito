using System.Collections.Generic;
using ExitoLogGames.App.Dominio;

namespace ExitoLogGames.App.Persistencia
{
    public interface IRepositorioSALE
    {
        IEnumerable<Sales> GetAllSALE();
        Sales AddSale(Sales sales);
        Sales UpdateSale(int Id, Sales sales);
        void DeleteSale(int Id);
        Sales GetSale(int Id); 
    }
}