using ExitoLogGames.App.Dominio;
using System.Linq;
using System;
using System.Collections.Generic;

namespace ExitoLogGames.App.Persistencia
{
    public class RepositorioControles : IRepositorioControles 
    {
       private readonly Connection conexion;
        public RepositorioControles(Connection conexion){
            this.conexion = conexion;
        }

        IEnumerable<Control> IRepositorioControles.GetAllControles(){
            return conexion.controles;
        }

        Control IRepositorioControles.AddControl(Control control){
            var cont = conexion.controles.Add(control);
            conexion.SaveChanges();
            Console.WriteLine("Se agrego el control correctamente");
            return  cont.Entity; 
        }

        Control IRepositorioControles.UpdateControl(int IdControl, Control control){
            var cont = conexion.controles.FirstOrDefault( f => f.Id == IdControl);
            if(cont!=null){
                cont.Nombre=control.Nombre;
                cont.Version=control.Version;
                cont.Fabricante=control.Fabricante;
                cont.Precio=control.Precio;
                cont.Costo=control.Costo;
                cont.Compatibilidad=control.Compatibilidad;
            }
            conexion.SaveChanges();
            return cont;
        }

        void IRepositorioControles.DeleteControl(int IdControl){
            var cont = conexion.controles.FirstOrDefault( f => f.Id == IdControl);
            if(cont!=null)
                return;
            conexion.controles.Remove(cont);
            conexion.SaveChanges();
            Console.WriteLine("Se elimino el control correctamente");            
        }

        Control IRepositorioControles.GetControl(int IdControl){
            return conexion.controles.FirstOrDefault( f => f.Id == IdControl);
        }  
    }
}