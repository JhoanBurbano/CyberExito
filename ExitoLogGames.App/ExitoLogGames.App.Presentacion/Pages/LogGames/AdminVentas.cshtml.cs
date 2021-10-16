using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace ExitoLogGames.App.Presentacion.Pages.LogGames
{
    public class AdminVentasModel : PageModel
    {
        private readonly ILogger<AdminVentasModel> _logger;

        public AdminVentasModel(ILogger<AdminVentasModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
