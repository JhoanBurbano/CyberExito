using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExitoLogGames.App.Dominio;

namespace ExitoLogGames.App.Persistencia
{
    public interface IRepositorioVideojuegos
    {
         IEnumerable<Videojuego> GetAllVideojuegos();
        Videojuego AddVideojuego(Videojuego videojuego);
        Videojuego UpdateVideojuego(int IdVideojuego, Videojuego videojuego);
        void DeleteVideojuego(int IdVideojuego);
        Videojuego GetVideojuego(int IdVideojuego);  
    }
}