using System.Collections.Generic;
using ExitoLogGames.App.Dominio;

namespace ExitoLogGames.App.Persistencia
{
    public interface IRepositorioVentas
    {
        IEnumerable<Sales> GetAllVentas();
        Sales AddVenta(Sales ventas);
        Sales UpdateVenta(int Id, Sales ventas);
        void DeleteVenta(int Id);
        Sales GetVenta(int Id); 
    }
}