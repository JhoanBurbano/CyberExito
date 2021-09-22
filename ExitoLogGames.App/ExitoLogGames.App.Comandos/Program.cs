using System;
using ExitoLogGames.App.Dominio;
using ExitoLogGames.App.Persistencia;

namespace ExitoLogGames.App.Comandos
{
    class Program
    {
        static void Main(string[] args)
        {
            Connection conexion = new Connection();
            Consola consola = new Consola();
            consola.Nombre="XBOX";
            consola.Version="2021";
            consola.Fabricante="Microsoft";
            consola.Precio=1500000;
            consola.Costo=1000000;
            consola.VelocidadProcesamiento="5 Mhz";
            consola.VelocidadRam="100m/s";
            consola.Storage="SSD";
            consola.CantidadControles=4;
            conexion.consolas.Add(consola);
            conexion.SaveChanges();
        }
    }
}
