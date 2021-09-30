using System.Collections.Generic;
using ExitoLogGames.App.Dominio;

namespace ExitoLogGames.App.Persistencia
{
    public interface IRepositorioAdministradores
    {
        IEnumerable<AdminVentas> GetAllAdministradores();
        AdminVentas AddAdministrador(AdminVentas adminVentas);
        AdminVentas UpdateAdministrador(AdminVentas adminVentas);
        void DeleteAdministrador(int IdAdminVentas);
        AdminVentas GetAdministrador(int IdAdminVentas);
    }
}