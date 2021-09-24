using ExitoLogGames.App.Persistencia;
using ExitoLogGames.App.Dominio;
using System.Linq;
using System;
using System.Collections.Generic;

namespace ExitoLogGames.App.Comandos
{
    public class RepositorioSale : IRepositorioSALE
    {
        private readonly Connection conexion;
        public RepositorioConsolas(Connection conexion){
            this.conexion = conexion;
        }
        IEnumerable<Sales> IRepositorioSALE.GetAllSALE(){
            return conexion.ventas;
        }
        Sales IRepositorioSALE.AddSale(Sales sales){
            var sle = conexion.ventas.Add(sale);
            conexion.SaveChanges();
            return  sle.Entity; 
            Console.WriteLine("Se agrego la venta correctamente");
        }     

        Sales IRepositorioSALE.UpdateSale(int Id, Sales sales){

        }

        void IRepositorioSALE.DeleteSale(int Id){
            var sle = conexion.ventas.FirstOrDefault( s => s.Id == Id);
            if(sle!=null)
                return;
            conexion.ventas.Remove(sle);
            conexion.SaveChanges();
            Console.WriteLine("Se elimino la venta correctamente");
        }
        Sales IRepositorioSALE.GetSale(int Id){
            return conexion.ventas.FirstOrDefault( s => s.Id == Id);
        }
    }
}