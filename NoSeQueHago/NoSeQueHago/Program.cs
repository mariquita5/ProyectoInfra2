using mySMTP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace NoSeQueHago
{
    class Program
    {
        static void Main(string[] args)
        {
            //MailMessage mail = new MailMessage();
            //mail.From = "admin@infratec.com";
            //mail.To = "jvega@infratec.com";
            //mail.Subject = "Prueba";
            //mail.Body = "Hola luuuuuu";

            ////SmtpDirect sm = new SmtpDirect();
            //SmtpDirect.Send(mail);

            MailMessage email = new MailMessage();
            email.To.Add(new MailAddress("lucia@infra2tec.com"));
            email.From = new MailAddress("j@infra2tec.com");
            email.Subject = "Asunto ( Hola Luuuuuuuuuu ) ";
            email.Body = "Cualquier contenido en <b>HTML</b> para enviarlo por correo electrónico.";
            email.IsBodyHtml = true;
            email.Priority = MailPriority.Normal;

            SmtpClient smtp = new SmtpClient();
            smtp.Host = "infra2tec.com";
            smtp.Port = 2525;
            smtp.EnableSsl = false;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential("lucia@infra2tec.com", "hola12345");

            string output = null;

            try
            {
                smtp.Send(email);
                email.Dispose();
                output = "Corre electrónico fue enviado satisfactoriamente.";
            }
            catch (Exception ex)
            {
                output = "Error enviando correo electrónico: " + ex.Message;
            }

            Console.WriteLine(output);
        }
    }
}
