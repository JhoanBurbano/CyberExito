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
    public class InfoModel : PageModel
    {
        private readonly Connection _conexion;

        public InfoModel(Connection conexion)
        {
            _conexion = conexion;
        }


        public void OnGet()
        {

        }

    }
}
