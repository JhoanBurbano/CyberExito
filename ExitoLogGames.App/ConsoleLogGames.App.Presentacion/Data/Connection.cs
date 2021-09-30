using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ExitoLogGames.App.Dominio;

namespace Persistencia
{
    public class Connection : DbContext
    {
        public Connection (DbContextOptions<Connection> options)
            : base(options)
        {
        }

        public DbSet<ExitoLogGames.App.Dominio.Vendedor> Vendedor { get; set; }
    }
}
