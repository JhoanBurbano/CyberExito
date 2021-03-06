using System;
using Microsoft.EntityFrameworkCore;
using ExitoLogGames.App.Dominio;

namespace ExitoLogGames.App.Persistencia
{
    public class Connection : DbContext
    {
        public DbSet<Employ> empleados{get;set;}
        public DbSet<Factura> facturas{get;set;}
        public DbSet<Consola> consolas{get;set;}
        public DbSet<Control> controles{get;set;}
        public DbSet<Videojuego> videojuegos{get;set;}

        protected override void OnConfiguring(DbContextOptionsBuilder builder){
            if(!builder.IsConfigured){
                builder.UseSqlServer("Data source = (localdb)\\MSSQLLocalDB; Initial Catalog = LabExitoGamesData");
            }
        }

    }
}
