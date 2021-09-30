using ExitoLogGames.App.Dominio;
using System.Linq;
using System.Collections.Generic;
using System;
 
namespace ExitoLogGames.App.Persistencia
{
    public class RepositorioCompras : IRepositorioCompras
    {
        private readonly Connection conexion;
        public RepositorioCompras(Connection conexion){
            this.conexion = conexion;
        }
        IEnumerable<Compras> IRepositorioCompras.GetAllCompras(){
            return conexion.compras;
        }
        Compras IRepositorioCompras.AddCompra(Compras compra){
            var comp = conexion.compras.Add(compra);
            conexion.SaveChanges();
            Console.WriteLine("Se creó la compra");
            return comp.Entity;

        }
        Compras IRepositorioCompras.UpdateCompra(int IdCompras,Compras compra){
            var comp = conexion.compras.FirstOrDefault(v => v.Id == IdCompras);
            if(comp!=null){
                comp.Factura=compra.Factura;              
                comp.Comprador=compra.Comprador;
                comp.Fecha=compra.Fecha;
            }
            conexion.SaveChanges();
            return comp;
        }
        void IRepositorioCompras.DeleteCompra(int IdCompra){
            var comp = conexion.compras.FirstOrDefault(v => v.Id == IdCompra);
            if(comp==null)
                return;
            conexion.compras.Remove(comp);
            conexion.SaveChanges();
            Console.WriteLine("Se eliminó compra");
        }
        Compras IRepositorioCompras.GetCompra(int IdCompra){
            return conexion.compras.FirstOrDefault( v => v.Id == IdCompra);
        }
        
    }
}