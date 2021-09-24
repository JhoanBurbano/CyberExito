using ExitoLogGames.App.Persistencia;
using ExitoLogGames.App.Dominio;
using System.Linq;
using System.Collections.Generic;
using System;

namespace ExitoLogGames.App.Comandos
{
    public class RepositorioVendedores : IRepositorioVendedores
    {
        private readonly Connection conexion;
        public RepositorioVendedores(Connection conexion){
            this.conexion = conexion;
        }
        IEnumerable<Vendedor> IRepositorioVendedores.GetAllVendedor(){
            return conexion.vendedores;
        }
        Vendedor IRepositorioVendedores.AddVendedor(Vendedor vendedor){
            var vend = conexion.vendedores.Add(vendedor);
            return vend.Entity;
            Console.WriteLine("Se creó el vendedor");

        }
        Vendedor IRepositorioVendedores.UpdateVendedor(Vendedor vendedor){
            var vend = conexion.vendedores.FirstOrDefault(v => v.Cedula == v.Cedula);
            if(vend!=null){
                vend.Nombre=vendedor.Nombre;
                vend.Apellido=vendedor.Apellido;
                vend.Cedula=vendedor.Cedula;
                vend.Sucursal=vendedor.Sucursal;
                vend.Usuario=vendedor.Usuario;
                vend.Password=vendedor.Nombre;
                vend.Cargo=vendedor.Cargo;
            }
            return vend;
        }
        void IRepositorioVendedores.DeleteVendedor(int IdVendedor){
            var vend = conexion.vendedores.FirstOrDefault(v => v.Id == IdVendedor);
            if(vend==null)
                return;
            conexion.vendedores.Remove(vend);
            Console.WriteLine("Se eliminó el vendedor");
        }
        Vendedor IRepositorioVendedores.GetVendedor(int IdVendedor){
            return conexion.vendedores.FirstOrDefault( v => v.Id == IdVendedor);
        }
        
    }
}