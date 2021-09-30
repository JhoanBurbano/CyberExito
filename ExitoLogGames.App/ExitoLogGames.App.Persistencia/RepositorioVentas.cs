using ExitoLogGames.App.Dominio;
using System.Linq;
using System;
using System.Collections.Generic;

namespace ExitoLogGames.App.Persistencia
{
    public class RepositorioVentas : IRepositorioVentas
    {
        private readonly Connection conexion;
        public RepositorioVentas(Connection conexion)
        {
            this.conexion = conexion;
        }
        IEnumerable<Sales> IRepositorioVentas.GetAllVentas()
        {
            return conexion.ventas;
        }
        Sales IRepositorioVentas.AddVenta(Sales venta)
        {
            var sle = conexion.ventas.Add(venta);
            conexion.SaveChanges();
            Console.WriteLine("Se agrego la venta correctamente");
            return sle.Entity;
        }

        Sales IRepositorioVentas.UpdateVenta(int IdVenta, Sales venta)
        {
            var vent = conexion.ventas.FirstOrDefault(v => v.Id == IdVenta);
            if (vent != null)
            {
                vent.Factura = venta.Factura;
                vent.Vendedor = venta.Vendedor;
                vent.Fecha = venta.Fecha;
            }
            conexion.SaveChanges();
            return vent;
        }

        void IRepositorioVentas.DeleteVenta(int IdVenta)
        {
            var sle = conexion.ventas.FirstOrDefault(s => s.Id == IdVenta);
            if (sle != null)
                return;
            conexion.ventas.Remove(sle);
            conexion.SaveChanges();
            Console.WriteLine("Se elimino la venta correctamente");
        }
        Sales IRepositorioVentas.GetVenta(int IdVenta)
        {
            return conexion.ventas.FirstOrDefault(s => s.Id == IdVenta);
        }
    }
}