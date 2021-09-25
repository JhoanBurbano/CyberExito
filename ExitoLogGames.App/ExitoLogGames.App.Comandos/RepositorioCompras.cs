using ExitoLogGames.App.Persistencia;
using ExitoLogGames.App.Dominio;
using System.Linq;
using System.Collections.Generic;
using System;

namespace ExitoLogGames.App.Comandos
{
    public class RepositorioCompras : IRepositorioCompras
    {
        private readonly Connection conexion;
        public RepositorioCompras(Connection conexion){
            this.conexion = conexion;
        }
        IEnumerable<Compra> IRepositoriocompedores.GetAllCompra(){
            return conexion.compedores;
        }
        compedor IRepositorioCompras.Addcompedor(Compra Compra){
            var comp = conexion.compras.Add(compra);
            return comp.Entity;
            Console.WriteLine("Se creó la compra");

        }
        compedor IRepositorioCompras.UpdateCompra(Compra Compra){
            var comp = conexion.compras.FirstOrDefault(v => v.Id == v.Id);
            if(comp!=null){
                comp.Id=compra.Id;
                comp.Factura=compra.Factura;              
                comp.Comprador=compra.Comprador;
                comp.Fecha=compra.Fecha;
            }
            return comp;
        }
        void IRepositorioCompras.DeleteCompra(int IdCompra){
            var comp = conexion.Compras.FirstOrDefault(v => v.Id == IdCompra);
            if(comp==null)
                return;
            conexion.compras.Remove(comp);
            Console.WriteLine("Se eliminó compra");
        }
        compedor IRepositoriocompedores.GetCompra(int IdCompra){
            return conexion.compras.FirstOrDefault( v => v.Id == IdCompra);
        }
        
    }
}