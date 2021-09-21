using System;
using ExitoLogGames.App.Dominio;
using ExitoLogGames.App.Persistencia;

namespace ExitoLogGames.App.Comandos
{
    class Program
    {
        static void Main(string[] args)
        {
            Employ employ = new Employ();
            employ.Nombre = "Juan";
            employ.Apellido = "Muñoz";
            employ.Cedula = "11223757";
            employ.Sucursal = "ValleDelili";
            employ.Usuario="juan@email.com";
            employ.Password=employ.Cedula;
            Console.WriteLine("Password: " + employ.Password);
            Connection conexion = new Connection();
            conexion.empleados.Add(employ);
            conexion.SaveChanges();
        }
    }
}
