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
    public class ListaDeConsolasModel : PageModel
    {
        private readonly Connection _conexion;

        public ListaDeConsolasModel(Connection conexion)
        {
            _conexion = conexion;
        }

        public IEnumerable<Consola> Consolas{get;set;}

        [BindProperty]
        public Employ Empleado{get;set;}

        public async Task OnGet(int id)
        {
            Consolas = await _conexion.consolas.ToListAsync();
            // Empleado = _conexion.empleados.FirstOrDefault(x=>x.Id==id);
        }


    }
}
