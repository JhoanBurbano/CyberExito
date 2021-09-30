using System.Collections.Generic;
using ExitoLogGames.App.Dominio;

namespace ExitoLogGames.App.Persistencia
{
    public interface IRepositorioCompradores
    {
        IEnumerable<AdminCompras> GetAllCompradores();
        AdminCompras AddComprador(AdminCompras admincompras);
        AdminCompras UpdateComprador(AdminCompras admincompras);
        void DeleteComprador(int IdAdminCompras);
        AdminCompras GetComprador(int IdAdminCompras);
    }
}