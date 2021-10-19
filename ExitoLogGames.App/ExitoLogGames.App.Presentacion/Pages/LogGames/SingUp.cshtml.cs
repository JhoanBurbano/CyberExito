using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace ExitoLogGames.App.Presentacion.Pages.LogGames
{
    public class SingUpModel : PageModel
    {
        private readonly Connection _conexion;

        public SingUpModel(Connection conexion)
        {
            _conexion = conexion;
        }

        [BindProperty]

        public AdminVentas Administrador{get;set;}

        public void OnGet()
        {

        }
    }
}
