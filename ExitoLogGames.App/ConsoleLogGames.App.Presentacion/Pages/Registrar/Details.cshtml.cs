using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ExitoLogGames.App.Dominio;
using ExitoLogGames.App.Persistencia;

namespace ConsoleLogGames.App.Presentacion.Pages.Registrar
{
    public class DetailsModel : PageModel
    {
        private readonly ExitoLogGames.App.Persistencia.Connection _context;

        public DetailsModel(ExitoLogGames.App.Persistencia.Connection context)
        {
            _context = context;
        }

        public Vendedor Vendedor { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Vendedor = await _context.vendedores.FirstOrDefaultAsync(m => m.Id == id);

            if (Vendedor == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
