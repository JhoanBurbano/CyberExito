using System.Collections.Generic;
using ExitoLogGames.App.Dominio;

namespace ExitoLogGames.App.Persistencia
{
    public interface IRepositorioCompras
    {
        IEnumerable<Compras> GetAllCompras();
        Compras AddCompra(Compras Compras);
        Compras UpdateCompra(int IdCompra, Compras Compras);
        void DeleteCompra(int IdCompras);
        Compras GetCompra(int IdCompras);
    }
}