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
    public class RegistrarVentaModel : PageModel
    {
        private readonly Connection _conexion;

        public RegistrarVentaModel(Connection conexion)
        {
            _conexion = conexion;
        }

        public IEnumerable<Employ> Empleados{get;set;}
        public IEnumerable<Consola> Consolas{get;set;}
        public IEnumerable<Control> Controles{get;set;}
        public IEnumerable<Videojuego> Videojuegos{get;set;}
        

        [BindProperty]
        public Factura Venta { get; set; }

        public async void OnGet()
        {
            Empleados=_conexion.empleados.Where(x=>x.Cargo=="Vendedor").ToList();
            Consolas=_conexion.consolas.Where(x=>x.Nombre!=null).ToList();
            Controles=_conexion.controles.Where(x=>x.Nombre!=null).ToList();
            Videojuegos=_conexion.videojuegos.Where(x=>x.Nombre!=null).ToList();
            
        }

        public async Task<IActionResult> OnPost(){
            if(ModelState.IsValid){
                var fact = _conexion.facturas.Add(new Factura()).Entity;
                fact=_conexion.facturas.FirstOrDefault(x=>x.Id==fact.Id);
                
                await _conexion.SaveChangesAsync();
                return RedirectToPage("/LogGames/ListaDeVentas");
            }
            return Page();
        }

    }
}
