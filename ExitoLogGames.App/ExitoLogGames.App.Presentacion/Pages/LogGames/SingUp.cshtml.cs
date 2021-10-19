using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using ExitoLogGames.App.Persistencia;
using ExitoLogGames.App.Dominio;

namespace ExitoLogGames.App.Presentacion.Pages.LogGames
{
    public class SingUpModel : PageModel
    {
        private readonly Connection _conexion;

        public SingUpModel(Connection conexion)
        {
            _conexion = conexion;
        }

        [BindProperty]
        public Employ Empleado{get;set;}

        public Employ cd{get;set;}

        public void OnGet()
        {

        }

        public async Task<IActionResult> OnPost(){
            if (ModelState.IsValid){
                Empleado.Password = Empleado.Cedula;
                await _conexion.empleados.AddAsync(Empleado);
                await _conexion.SaveChangesAsync();

                cd = _conexion.empleados.FirstOrDefault(e => e.Usuario == Empleado.Usuario);


                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential("burbanolabscorp@gmail.com", "EmpanadasConaJi123.");

                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("burbanolabscorp@gmail.com", "Confirma la Creacion de tu cuenta");
                mail.To.Add(new MailAddress(Empleado.Usuario));
                mail.Subject = $"Codigo de confirmacion";
                mail.IsBodyHtml = true;
                mail.Body = $"<h1>Hola {cd.Nombre} {cd.Apellido}, este es el link para tu inicio de sesion.</h1> <p><a href='https://localhost:5001/LogGames/FirstLogin'> https://localhost:5001/LogGames/FirstLogin</a></p><p><b>Bienvenido a Exito Log Games<b/></p>";
                smtp.Send(mail);


                return RedirectToPage("/LogGames/Info");
            }
            return Page();
        }
    }
}
