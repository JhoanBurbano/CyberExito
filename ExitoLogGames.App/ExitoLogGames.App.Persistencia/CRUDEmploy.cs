using System.Collections.Generic;
using ExitoLogGames.App.Dominio;

namespace ExitoLogGames.App.Persistencia
{
    public interface CRUDEmploy
    {
        IEnumerable<Employ> GetAllEmploys();
        Employ AddEmploy(Employ employ);
        Employ UpdateEmploy(Employ employ);
        void DeleteEmploy(int IdEmploy);
        Employ GetEmploy(int IdEmploy);
    }
}