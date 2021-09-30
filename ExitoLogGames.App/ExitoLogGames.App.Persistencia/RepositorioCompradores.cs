using ExitoLogGames.App.Dominio;
using System.Linq;
using System.Collections.Generic;
using System;

namespace ExitoLogGames.App.Persistencia
{
    public class RepositorioCompradores : IRepositorioCompradores
    {
        private readonly Connection conexion;
        public RepositorioCompradores(Connection conexion){
            this.conexion = conexion;
        }
        IEnumerable<AdminCompras> IRepositorioCompradores.GetAllCompradores(){
            return conexion.compradores;
        }
        AdminCompras IRepositorioCompradores.AddComprador(AdminCompras comprador){
            var comp = conexion.compradores.Add(comprador);
            conexion.SaveChanges();
            Console.WriteLine("Se creó el comprador");
            return comp.Entity;

        }
        AdminCompras IRepositorioCompradores.UpdateComprador(AdminCompras comprador){
            var comp = conexion.compradores.FirstOrDefault(v => v.Cedula == v.Cedula);
            if(comp!=null){
                comp.Nombre=comprador.Nombre;
                comp.Apellido=comprador.Apellido;
                comp.Cedula=comprador.Cedula;
                comp.Sucursal=comprador.Sucursal;
                comp.Usuario=comprador.Usuario;
                comp.Password=comprador.Nombre;
                comp.Cargo=comprador.Cargo;
            }
            conexion.SaveChanges();
            return comp;
        }
        void IRepositorioCompradores.DeleteComprador(int IdComprador){
            var comp = conexion.compradores.FirstOrDefault(v => v.Id == IdComprador);
            if(comp==null)
                return;
            conexion.compradores.Remove(comp);
            conexion.SaveChanges();
            Console.WriteLine("Se eliminó el comprador");
        }
        AdminCompras IRepositorioCompradores.GetComprador(int IdComprador){
            return conexion.compradores.FirstOrDefault( v => v.Id == IdComprador);
        }
    }
}