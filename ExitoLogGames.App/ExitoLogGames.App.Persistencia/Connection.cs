using System;
using Microsoft.EntityFrameworkCore;
using ExitoLogGames.App.Dominio;

namespace ExitoLogGames.App.Persistencia
{
    public class Connection : DbContext
    {
        public DbSet<Employ> empleados{get;set;}
        // public DbSet<Sales> ventas{get;set;}
        // public DbSet<Compras> compras{get;set;}
        public DbSet<Consola> consolas{get;set;}

        protected override void OnConfiguring(DbContextOptionsBuilder builder){
            if(!builder.IsConfigured){
                builder.UseSqlServer("Data source = (localdb)\\MSSQLLocalDB; Initial Catalog = ExitoLogGames.Data");
            }
        }

    }
}
