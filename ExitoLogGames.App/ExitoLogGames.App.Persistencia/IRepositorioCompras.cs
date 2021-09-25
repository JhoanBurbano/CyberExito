using System.Collections.Generic;
using ExitoLogGames.App.Dominio;

namespace ExitoLogGames.App.Persistencia
{
    public interface IRepositorioCompras
    {
        IEnumerable<Compras> GetAllCompras();
        Compras AddCompras(Compras Compras);
        Compras UpdateCompras(Compras Compras);
        void DeleteCompras(int IdCompras);
        Compras GetCompras(int IdCompras);
    }
}