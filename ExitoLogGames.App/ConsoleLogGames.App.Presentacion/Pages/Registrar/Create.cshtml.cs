using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ExitoLogGames.App.Dominio;
using ExitoLogGames.App.Persistencia;

namespace ConsoleLogGames.App.Presentacion.Pages.Registrar
{
    public class CreateModel : PageModel
    {
        private readonly ExitoLogGames.App.Persistencia.Connection _context;

        public CreateModel(ExitoLogGames.App.Persistencia.Connection context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Vendedor Vendedor { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.vendedores.Add(Vendedor);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
