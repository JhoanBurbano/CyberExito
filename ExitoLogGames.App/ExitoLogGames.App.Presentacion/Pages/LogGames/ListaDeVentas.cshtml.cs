using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using ExitoLogGames.App.Persistencia;
using ExitoLogGames.App.Dominio;
using Microsoft.EntityFrameworkCore;

namespace ExitoLogGames.App.Presentacion.Pages.LogGames
{
    public class ListaDeVentasModel : PageModel
    {
        private readonly Connection _conexion;

        public ListaDeVentasModel(Connection conexion)
        {
            _conexion = conexion;
        }

        public IEnumerable<Factura> Ventas{get;set;}
        public IEnumerable<Consola> Consolas{get;set;}

        [BindProperty]
        public Employ Empleado{get;set;}

        public async Task OnGet(int id)
        {
            Ventas = await _conexion.facturas.ToListAsync();
            Consolas = await _conexion.consolas.ToListAsync();
            Empleado = _conexion.empleados.FirstOrDefault(x=>x.Id==id);
        }


    }
}
