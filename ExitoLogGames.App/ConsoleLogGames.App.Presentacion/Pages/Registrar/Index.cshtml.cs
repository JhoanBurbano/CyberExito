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
    public class IndexModel : PageModel
    {
        private readonly ExitoLogGames.App.Persistencia.Connection _context;

        public IndexModel(ExitoLogGames.App.Persistencia.Connection context)
        {
            _context = context;
        }

        public IList<Vendedor> Vendedor { get;set; }

        public async Task OnGetAsync()
        {
            Vendedor = await _context.vendedores.ToListAsync();
        }
    }
}
