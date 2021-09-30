using System.Collections.Generic;
using ExitoLogGames.App.Dominio;

namespace ExitoLogGames.App.Persistencia
{
    public interface IRepositorioVendedores
    {
        IEnumerable<Vendedor> GetAllVendedores();
        Vendedor AddVendedor(Vendedor vendedor);
        Vendedor UpdateVendedor(Vendedor vendedor);
        void DeleteVendedor(int IdVendedor);
        Vendedor GetVendedor(int IdVendedor);
    }
}