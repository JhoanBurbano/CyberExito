// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;
// using ExitoLogGames.App.Dominio;
// namespace ExitoLogGames.App.Persistencia
// {
//     public class RFlujo
//     {
//         //Instancias de las interfaces repositorios al repositorio(CRUD) y le pasamos como parametros la conexion.
//         private Connection conexion = new Connection();
//         private IRepositorioConsolas rconsola =  new RepositorioConsolas(new Connection());
//         private IRepositorioControles rcontrol = new RepositorioControles(new Connection());
//         private IRepositorioVideojuegos rvideojuego = new RepositorioVideojuegos(new Connection());
//         private IRepositorioCompras rcompras = new RepositorioCompras(new Connection());
//         private IRepositorioOrders rorders = new RepositorioOrders(new Connection());
//         private IRepositorioFactura rfactura = new RepositorioFactura(new Connection());

//         public void btnCrearCtr(Control ctr){
//             Control cont = conexion.controles.FirstOrDefault(c => c.Nombre == ctr.Nombre);
//             if(cont == null){
//                 rcontrol.AddControl(ctr);
//             }else{

//                 cont.Nombre=cont.Nombre;
//                 cont.Version=cont.Version;
//                 cont.Fabricante=cont.Fabricante;
//                 cont.Precio=cont.Precio;
//                 cont.Costo=cont.Costo;
//                 cont.Compatibilidad=cont.Compatibilidad;
//                 cont.Cantidad+=ctr.Cantidad;
//                 rcontrol.UpdateControl(cont.Id, cont);
            
//             }
//             Hasta aqui se valida si existe un producto igual o si es nuevo
//             Orders ord = new Orders();
//             rcompras.AddCompra(ord);
//             ord = conexion.compras.FirstOrDefault(o => (o.Cantidad == null));
//             ord.Producto = ctr;
//             ord.Consola = null;
//             ord.Videojuego = null;
//             ord.Cantidad = ctr.Cantidad;
//             ord.Operacion = "compra";
//             ord.SubTotal = ctr.Costo*ctr.Cantidad;
//             Orders od = rcompras.UpdateCompras(ord.Id, ord);
            

//             Factura fact = new Factura();
//             rfactura.AddFactura(fact);
//             fact=conexion.facturas.FirstOrDefault(f => f.Fecha == null);
//             fact.PedidoControles=od;
//             fact.Fecha = DateTime.Now();
//             fact.Total = od.SubTotal;
//             fact.Pagada = true;
//             Factura fc = rfactura.UpdateFactura(fact.Id, fact);
            
            


//         }


//     }
    
// }
