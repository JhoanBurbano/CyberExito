using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExitoLogGames.App.Dominio
{
    public class Consola : Product
    {
        public int Id{get;set;}
        public string CapacidadAlmacenamiento {get; set;}
        public string VelocidadRam {get; set;}
        public string VelocidadProcesamiento {get; set;}
        public int CantidadControles {get; set;}
        public string Storage {get; set;}
    }
}

//Sé que estás ahí Neo. ¿Quieres conocer la Matrix?