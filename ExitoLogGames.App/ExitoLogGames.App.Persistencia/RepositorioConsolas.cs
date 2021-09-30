using ExitoLogGames.App.Dominio;
using System.Linq;
using System;
using System.Collections.Generic;

namespace ExitoLogGames.App.Persistencia
{
    public class RepositorioConsolas : IRepositorioConsolas
    {
        private readonly Connection conexion;
        public RepositorioConsolas(Connection conexion){
            this.conexion = conexion;
        }

        IEnumerable<Consola> IRepositorioConsolas.GetAllConsolas(){
            return conexion.consolas;
        }

        Consola IRepositorioConsolas.AddConsola(Consola consola){
            var consol = conexion.consolas.Add(consola);
            conexion.SaveChanges();
            Console.WriteLine("Se agrego la consola correctamente");
            return  consol.Entity; 
        }

        Consola IRepositorioConsolas.UpdateConsola(int IdConsola, Consola consola){
            var consol = conexion.consolas.FirstOrDefault( c => c.Id == IdConsola);
            if(consol!=null){
                consol.Nombre=consola.Nombre;
                consol.Version=consola.Version;
                consol.Fabricante=consola.Fabricante;
                consol.Precio=consola.Precio;
                consol.Costo=consola.Costo;
                consol.CapacidadAlmacenamiento=consola.CapacidadAlmacenamiento;
                consol.VelocidadRam=consola.VelocidadRam;
                consol.VelocidadProcesamiento=consola.VelocidadProcesamiento;
                consol.CantidadControles=consola.CantidadControles;
                consol.Storage=consola.Storage;
            }
            conexion.SaveChanges();
            return consol;
        }

        void IRepositorioConsolas.DeleteConsola(int IdConsola){
            var consol = conexion.consolas.FirstOrDefault( c => c.Id == IdConsola);
            if(consol!=null)
                return;
            conexion.consolas.Remove(consol);
            conexion.SaveChanges();
            Console.WriteLine("Se elimino la consola correctamente");            
        }

        Consola IRepositorioConsolas.GetConsola(int IdConsola){
            return conexion.consolas.FirstOrDefault( c => c.Id == IdConsola);
        }

    }
}