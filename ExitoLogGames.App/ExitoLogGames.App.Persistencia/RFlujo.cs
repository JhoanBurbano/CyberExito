using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExitoLogGames.App.Dominio;
namespace ExitoLogGames.App.Persistencia
{
    public class RFlujo
    {
        //Instancias de las interfaces repositorios al repositorio(CRUD) y le pasamos como parametros la conexion.
        private Connection conexion = new Connection();
        private IRepositorioConsolas rconsola =  new RepositorioConsolas(new Connection());
        private IRepositorioControles rcontrol = new RepositorioControles(new Connection());
        private IRepositorioVideojuegos rvideojuego = new RepositorioVideojuegos(new Connection());
        private IRepositorioCompras rcompras = new RepositorioCompras(new Connection());
        private IRepositorioOrders rorders = new RepositorioOrders(new Connection());
        private IRepositorioFactura rfactura = new RepositorioFactura(new Connection());

        //Funcion para verificar los tipos de producto que hay.
        public void botonCrear(Product producto){
            switch(producto.Tipo){
                case "Videojuego" : 
                     rvideojuego.AddVideojuego(producto);
                    break;
                case "Control":
                    rcontrol.AddContron(producto);
                    break;
                case "Consola":
                    rconsola.AddConsola(producto);
                    break;
            }
        }
    }
}