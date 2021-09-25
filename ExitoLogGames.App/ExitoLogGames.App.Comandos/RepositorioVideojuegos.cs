using ExitoLogGames.App.Persistencia;
using ExitoLogGames.App.Dominio;
using System.Linq;
using System;
using System.Collections.Generic;

namespace ExitoLogGames.App.Comandos
{
    public class RepositorioVideojuegos : IRepositorioVideojuegos
    {
    private readonly Connection conexion;
        public RepositorioVideojuegos(Connection conexion){
            this.conexion = conexion;
        }

        IEnumerable<Videojuego> IRepositorioVideojuegos.GetAllVideojuegos(){
            return conexion.videojuegos;
        }

        Videojuego IRepositorioVideojuegos.AddVideojuego(Videojuego videojuego){
            var videoj = conexion.videojuegos.Add(videojuego);
            conexion.SaveChanges();
            return  videoj.Entity; 
            Console.WriteLine("Se agrego el videojuego correctamente");
        }

        Videojuego IRepositorioVideojuegos.UpdateVideojuego(int IdVideojuego, Videojuego videojuego){
            var videoj = conexion.videojuegos.FirstOrDefault( f => f.Id == IdVideojuego);
            if(videoj!=null){
                videoj.Nombre=videojuego.Nombre;
                videoj.Version=videojuego.Version;
                videoj.Fabricante=videojuego.Fabricante;
                videoj.Precio=videojuego.Precio;
                videoj.Costo=videojuego.Costo;
                videoj.Compatibilidad=videojuego.Compatibilidad;
            }
            conexion.SaveChanges();
            return videoj;
        }

        void IRepositorioVideojuegos.DeleteVideojuego(int IdVideojuego){
            var videoj = conexion.videojuegos.FirstOrDefault( f => f.Id == IdVideojuego);
            if(videoj!=null)
                return;
            conexion.videojuegos.Remove(videoj);
            conexion.SaveChanges();
            Console.WriteLine("Se elimino el videojuego correctamente");            
        }

        Videojuego IRepositorioVideojuegos.GetVideojuego(int IdVideojuego){
            return conexion.videojuegos.FirstOrDefault( f => f.Id == IdVideojuego);
        }      
    }
}