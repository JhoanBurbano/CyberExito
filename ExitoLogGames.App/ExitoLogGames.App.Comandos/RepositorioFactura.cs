using ExitoLogGames.App.Persistencia;
using ExitoLogGames.App.Dominio;
using System.Linq;
using System;
using System.Collections.Generic;

namespace ExitoLogGames.App.Comandos
{
    public class RepositorioFactura:IRepositorioFactura
    {
        private readonly Connection conexion;
        public RepositorioFactura(Connection conexion){
            this.conexion = conexion;
        }

        IEnumerable<Factura> IRepositorioFactura.GetAllFacturas(){
            return conexion.facturas;
        }

        Factura IRepositorioFactura.AddFactura(Factura factura){
            var fact = conexion.facturas.Add(factura);
            conexion.SaveChanges();
            return  fact.Entity; 
            Console.WriteLine("Se agrego la factura correctamente");
        }

        Factura IRepositorioFactura.UpdateFactura(int IdFactura, Factura factura){
            var fact = conexion.facturas.FirstOrDefault( f => f.Id == IdFactura);
            if(fact!=null){
                fact.PedidoConsolas=factura.PedidoConsolas;
                fact.PedidoControles=factura.PedidoControles;
                fact.PedidoVideojuegos=factura.PedidoVideojuegos;
                fact.Total=factura.Total;
                fact.Fecha=factura.Fecha;
            }
            conexion.SaveChanges();
            return fact;
        }

        void IRepositorioFactura.DeleteFactura(int IdFactura){
            var fact = conexion.facturas.FirstOrDefault( f => f.Id == IdFactura);
            if(fact!=null)
                return;
            conexion.facturas.Remove(fact);
            conexion.SaveChanges();
            Console.WriteLine("Se elimino la factura correctamente");            
        }

        Factura IRepositorioFactura.GetFactura(int IdFactura){
            return conexion.facturas.FirstOrDefault( f => f.Id == IdFactura);
        }
    }
}