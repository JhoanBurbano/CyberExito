using ExitoLogGames.App.Persistencia;
using ExitoLogGames.App.Dominio;
using System.Linq;
using System.Collections.Generic;
using System;

namespace ExitoLogGames.App.Comandos
{
    public class RepositorioCompradores : IRepositorioCompradores
    {
        private readonly Connection conexion;
        public RepositorioCompradores(Connection conexion){
            this.conexion = conexion;
        }
        IEnumerable<AdminCompras> IRepositorioCompradores.GetAllComprador(){
            return conexion.compradores;
        }
        AdminCompras IRepositorioCompradores.AddComprador(AdminCompras comprador){
            var comp = conexion.compradores.Add(comprador);
            return comp.Entity;
            Console.WriteLine("Se creó el comprador");

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
            return comp;
        }
        void IRepositorioCompradores.DeleteComprador(int IdComprador){
            var comp = conexion.compradores.FirstOrDefault(v => v.Id == IdComprador);
            if(comp==null)
                return;
            conexion.compradores.Remove(comp);
            Console.WriteLine("Se eliminó el comprador");
        }
        AdminCompras IRepositorioCompradores.GetComprador(int IdComprador){
            return conexion.compradores.FirstOrDefault( v => v.Id == IdComprador);
        }
    }
}