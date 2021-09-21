using System;
using Microsoft.EntityFrameworkCore;
using ExitoLogGames.App.Dominio;

namespace ExitoLogGames.App.Persistencia
{
    public class Connection : DbContext
    {
        DbSet<Employ> empleados{get;set;}

        protected override void OnConfiguring(DbContextOptionsBuilder builder){
            if(!builder.IsConfigured){
                builder.UseSqlServer("Data source = (localdb)\\MSSQLLocalDB; Initial Catalog = ExitoLogGames.Data");
            }
        }

    }
}
