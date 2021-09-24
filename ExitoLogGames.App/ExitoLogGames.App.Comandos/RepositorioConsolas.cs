using ExitoLogGames.App.Persistencia;
using ExitoLogGames.App.Dominio;
using System.Linq;
using System;
using System.Collections.Generic;

namespace ExitoLogGames.App.Comandos
{
    public class RepositorioConsolas : IRepositorioConsolas
    {
        private readonly Connection conexion;
        public RepositorioConsolas(Connection conexion){
            this.conexion = conexion;
        }

        IEnumerable<Consolas> IrepositorioConsolas.GetAllConsolas(){
            return conexion.consolas;
        }

        Consola IrepositorioConsolas.AddConsola(Consola consola){
            var consol = conexion.consolas.Add(consola);
            return  consol.Entity; 
            Console.WriteLines("Se agrego la consola correctamente");
        }

        Consola IrepositorioConsolas.UpdateConsola(Consola consola){
            var consol = conexion.consolas.FirstOrDefault( c => c.id = c.Cedula);
            if(consol!=null){
                consol.CapacidadAlmacenamiento=consola.CapacidadAlmacenamiento;
                consol.VelocidadRam=consola.VelocidadRam;
                consol.VelocidadProcesamiento=consola.VelocidadProcesamiento;
                consol.CantidadControles=consola.CantidadControles;
                consol.Storage=consola.Storage;
            }
            return consol;
        }

        void IrepositorioConsolas.DeleteConsola(int IdConsola){
            var consol = conexion.consolas.FirstOrDefault( c => c.id == IdConsola);
            if(consol!=null)
                return;
            conexion.consolas.Remove(consol);
            Console.WriteLines("Se elimino la consola correctamente");            
        }

        Consola IrepositorioConsolas.GetConsola(int IdConsola){
            return conexion.consolas.FirstOrDefault( c => c.Id == IdConsola);
        }

    }
}