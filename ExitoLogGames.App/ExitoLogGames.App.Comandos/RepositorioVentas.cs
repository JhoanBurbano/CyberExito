using ExitoLogGames.App.Persistencia;
using ExitoLogGames.App.Dominio;
using System.Linq;
using System;
using System.Collections.Generic;

namespace ExitoLogGames.App.Comandos
{
    public class RepositorioSale : IRepositorioVentas
    {
        private readonly Connection conexion;
        public RepositorioConsolas(Connection conexion){
            this.conexion = conexion;
        }
        IEnumerable<Sales> IRepositorioVentas.GetAllVentas(){
            return conexion.ventas;
        }
        Sales IRepositorioVentas.AddVenta(Sales sales){
            var sle = conexion.ventas.Add(sale);
            conexion.SaveChanges();
            return  sle.Entity; 
            Console.WriteLine("Se agrego la venta correctamente");
        }     

        Sales IRepositorioVentas.UpdateVenta(int Id, Sales sales){

        }

        void IRepositorioVentas.DeleteVenta(int Id){
            var sle = conexion.ventas.FirstOrDefault( s => s.Id == Id);
            if(sle!=null)
                return;
            conexion.ventas.Remove(sle);
            conexion.SaveChanges();
            Console.WriteLine("Se elimino la venta correctamente");
        }
        Sales IRepositorioVentas.GetVenta(int Id){
            return conexion.ventas.FirstOrDefault( s => s.Id == Id);
        }
    }
}