using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using ExitoLogGames.App.Persistencia;
using ExitoLogGames.App.Dominio;

namespace ExitoLogGames.App.Presentacion.Pages.LogGames
{
    public class CrearConsolaModel : PageModel
    {
        private readonly Connection _conexion;

        public CrearConsolaModel(Connection conexion)
        {
            _conexion = conexion;
        }

        [BindProperty]
        public Consola Consola { get; set; }

        public void OnGet()
        {

        }

        public async Task<IActionResult> OnPost(){
            if(ModelState.IsValid){
                await _conexion.consolas.AddAsync(Consola);
                await _conexion.SaveChangesAsync();
                return RedirectToPage("/LogGames/ListaDeConsolas");
            }
            return Page();
        }

    }
}
