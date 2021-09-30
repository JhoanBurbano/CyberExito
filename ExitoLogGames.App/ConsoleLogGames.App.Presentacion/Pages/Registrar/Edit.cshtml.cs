using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ExitoLogGames.App.Dominio;
using ExitoLogGames.App.Persistencia;

namespace ConsoleLogGames.App.Presentacion.Pages.Registrar
{
    public class EditModel : PageModel
    {
        private readonly ExitoLogGames.App.Persistencia.Connection _context;

        public EditModel(ExitoLogGames.App.Persistencia.Connection context)
        {
            _context = context;
        }

        [BindProperty]
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

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Vendedor).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VendedorExists(Vendedor.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool VendedorExists(int id)
        {
            return _context.vendedores.Any(e => e.Id == id);
        }
    }
}
