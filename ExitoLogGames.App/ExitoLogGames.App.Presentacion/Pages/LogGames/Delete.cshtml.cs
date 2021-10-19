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
    public class BorrarModel : PageModel
    {
        private readonly Connection _conexion;

        public BorrarModel(Connection conexion)
        {
            _conexion = conexion;
        }

        [BindProperty]
        public Consola Consola { get; set; }

        public async void OnGet(int id)
        {
            Consola = _conexion.consolas.FirstOrDefault(x=>x.Id == id );
        }

        public async Task<IActionResult> OnPost(){
            var uc= _conexion.consolas.FirstOrDefault(c=>c.Id==Consola.Id);
            if(uc!=null){
              _conexion.consolas.Remove(uc);
             await _conexion.SaveChangesAsync();
            return RedirectToPage("/LogGames/ListaDeConsolas");
            }
            return Page();
        }

    }
}
