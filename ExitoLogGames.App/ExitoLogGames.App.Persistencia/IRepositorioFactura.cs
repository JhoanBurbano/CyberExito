using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExitoLogGames.App.Dominio;

namespace ExitoLogGames.App.Persistencia
{
    public interface IRepositorioFactura
    {
        IEnumerable<Factura> GetAllFacturas();
        Factura AddFactura(Factura factura);
        Factura UpdateFactura(int IdFactura, Factura factura);
        void DeleteFactura(int IdFactura);
        Factura GetFactura(int IdFactura); 
    }
}