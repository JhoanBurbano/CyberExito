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
    public class EditarModel : PageModel
    {
        private readonly Connection _conexion;

        public EditarModel(Connection conexion)
        {
            _conexion = conexion;
        }

        [BindProperty]
        public Consola Consola { get; set; }

        public async void OnGet(int id)
        {
            Consola = _conexion.consolas.FirstOrDefault(x=>x.Id == id);
        }

        public async Task<IActionResult> OnPost(){
            var uc= await _conexion.consolas.FindAsync(Consola.Id);
            if(ModelState.IsValid && uc!=null){
            uc.Nombre=Consola.Nombre;
            uc.Version=Consola.Version;
            uc.Fabricante=Consola.Fabricante;
            uc.Precio=Consola.Precio;
            uc.Costo=Consola.Costo;
            uc.Cantidad=Consola.Cantidad;
            uc.CapacidadAlmacenamiento=Consola.CapacidadAlmacenamiento;
            uc.VelocidadRam=Consola.VelocidadRam;
            uc.VelocidadProcesamiento=Consola.VelocidadProcesamiento;
            uc.CantidadControles=Consola.CantidadControles;
            uc.Storage=Consola.Storage;
             await _conexion.SaveChangesAsync();
            return RedirectToPage("/LogGames/ListaDeConsolas");
            }
            return Page();
        }

    }
}
