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
    public class ForgetPasswordModel : PageModel
    {
        private readonly Connection _conexion;

        public ForgetPasswordModel(Connection conexion)
        {
            _conexion = conexion;
        }

        [BindProperty]
        public Employ Empleado { get; set; }
        public Employ emp;

        public void OnGet()
        {

        }

        public async Task<IActionResult> OnPost()
        {
            emp = _conexion.empleados.FirstOrDefault(emp => emp.Usuario == Empleado.Usuario);
            if (emp != null)
            {

                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential("burbanolabscorp@gmail.com", "EmpanadasConaJi123.");

                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("burbanolabscorp@gmail.com", "Confirma la Creacion de tu cuenta");
                mail.To.Add(new MailAddress(Empleado.Usuario));
                mail.Subject = $"Restablecer tu contraseña";
                mail.IsBodyHtml = true;
                mail.Body = $"<h1>Hola {emp.Nombre} {emp.Apellido}, estas son tus credenciales:\nTu usuario: <b>{emp.Usuario}</b>\nTu contraseña: <b>{emp.Password}</b>\n.</h1> <p>ingresa con tus credenciales en el siguiente link: <a href='https://localhost:5001/LogGames/Login'> https://localhost:5001/LogGames/FirstLogin</a></p><p><b>Exito Log Games<b/></p>";
                smtp.Send(mail);
                return RedirectToPage("/Index");
            }
            return Page();
        }
    }
}
