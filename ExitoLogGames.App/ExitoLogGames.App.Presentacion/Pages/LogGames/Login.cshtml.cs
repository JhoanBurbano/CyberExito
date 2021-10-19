using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using ExitoLogGames.App.Persistencia;
using ExitoLogGames.App.Dominio;

namespace ExitoLogGames.App.Presentacion.Pages.LogGames
{
    public class LoginModel : PageModel
    {
        private readonly Connection _conexion;

        public LoginModel(Connection conexion)
        {
            _conexion = conexion;
        }

        [BindProperty]
        public Employ Empleado { get; set; }
        public Employ cd { get; set; }
        public void OnGet()
        {

        }

        public async Task<IActionResult> OnPost()
        {
            //  && (cd.Cedula == cd.Password)
            cd = _conexion.empleados.FirstOrDefault(e => (e.Usuario == Empleado.Usuario) && (e.Password == Empleado.Password));
            if (cd != null)
            {
                var ced = cd.Cedula;
                if (ced == Empleado.Password)
                {
                    return RedirectToPage("/LogGames/FirstLogin");
                    // return Page();
                }
                var cg = cd.Cargo;
                switch (cg)
                {
                    case "AdminCompras":
                        return RedirectToPage("/LogGames/ListaDeConsolas");
                    case "AdminVentas":
                        return RedirectToPage("/LogGames/Administracion");
                    case "Vendedor":
                        return RedirectToPage($"/LogGames/ListaDeVentas");
                    default: return RedirectToPage("/Error");
                }

            }
            return RedirectToPage("/Index");

        }
    }
}
