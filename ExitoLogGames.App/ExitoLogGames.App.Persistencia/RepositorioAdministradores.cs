using ExitoLogGames.App.Dominio;
using System.Linq;
using System.Collections.Generic;
using System;

namespace ExitoLogGames.App.Persistencia
{
    public class RepositorioAdministradores : IRepositorioAdministradores
    {
        private readonly Connection conexion;
        public RepositorioAdministradores(Connection conexion){
            this.conexion = conexion;
        }
        IEnumerable<AdminVentas> IRepositorioAdministradores.GetAllAdministradores(){
            return conexion.administradores;
        }
        AdminVentas IRepositorioAdministradores.AddAdministrador(AdminVentas administrador){
            var adm = conexion.administradores.Add(administrador);
            conexion.SaveChanges();
            Console.WriteLine("Se creó el administrador");
            return adm.Entity;

        }
        AdminVentas IRepositorioAdministradores.UpdateAdministrador(AdminVentas administrador){
            var adm = conexion.administradores.FirstOrDefault(v => v.Cedula == administrador.Cedula);
            if(adm!=null){
                adm.Nombre=administrador.Nombre;
                adm.Apellido=administrador.Apellido;
                adm.Cedula=administrador.Cedula;
                adm.Sucursal=administrador.Sucursal;
                adm.Usuario=administrador.Usuario;
                adm.Password=administrador.Nombre;
                adm.Cargo=administrador.Cargo;
                adm.Compras=administrador.Compras;
                adm.Ventas=administrador.Ventas;
            }
            conexion.SaveChanges();
            return adm;
        }
        void IRepositorioAdministradores.DeleteAdministrador(int Idadministrador){
            var adm = conexion.administradores.FirstOrDefault(v => v.Id == Idadministrador);
            if(adm==null)
                return;
            conexion.administradores.Remove(adm);
            conexion.SaveChanges();
            Console.WriteLine("Se eliminó el administrador");
        }
        AdminVentas IRepositorioAdministradores.GetAdministrador(int Idadministrador){
            return conexion.administradores.FirstOrDefault( v => v.Id == Idadministrador);
        }
    }
}