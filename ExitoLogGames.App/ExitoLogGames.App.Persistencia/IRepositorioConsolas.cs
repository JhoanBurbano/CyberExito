using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExitoLogGames.App.Dominio;

namespace ExitoLogGames.App.Persistencia
{
    public interface IRepositorioConsolas
    {
        IEnumerable<Consola> GetAllConsolas();
        Consola AddConsola(Consola consola);
        Consola UpdateConsola(Consola consola);
        void DeleteConsola(int IdConsola);
        Consola GetConsola(int IdConsola); 
    }
}