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
    public class FirstLoginModel : PageModel
    {
        private readonly Connection _conexion;
        
        public FirstLoginModel(Connection conexion)
        {
            _conexion = conexion;
        }

        [BindProperty]
        public Employ Empleado{get;set;}
        public Employ emp;

        public void OnGet()
        {

        }

        public async Task<IActionResult> OnPost(){
            emp = _conexion.empleados.FirstOrDefault(emp=>emp.Cedula == Empleado.Cedula);
            if (emp!=null && emp.Cedula != Empleado.Password){
                emp.Password = Empleado.Password;
                _conexion.SaveChanges();
                return RedirectToPage("/Index");
            }
            return Page();
        }
    }
}
